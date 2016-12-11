using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UndoRedoCommand
{
    using UndoRedoCommand.Invoker;
    using UndoRedoCommand.Receiver;

    public partial class Form1 : Form
    {
        private Todo todo;

        private CommandInvoker invoker;

        public Form1()
        {
            this.todo = new Todo();
            this.invoker = new CommandInvoker(this.todo);

            this.InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var text = this.todoItem.Text.Trim();
            var theItem = new TodoItem
            {
                Id = Guid.NewGuid(),
                Item = text
            };

            if (text.Length > 0)
            {
                this.invoker.AddItem(theItem);
                this.BindTodoItems();

                this.todoItem.Text = string.Empty;
                this.todoItem.Focus();
            }
            else
            {
                this.todoItem.Focus();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.todoItem.Text.Trim() == string.Empty)
            {
                return;
            }

            var selectedItem = this.listBoxTodoItem.SelectedItem.ToString();
            var text = this.todoItem.Text.Trim();
            var updatableTodoItem = this.todo.todoList.Last(x => x.Item == selectedItem);

            var theItem = new TodoItem
            {
                Id = updatableTodoItem.Id,
                Item = selectedItem
            };

            if (text.Length > 0 && selectedItem != string.Empty)
            {
                updatableTodoItem.Item = text;
                this.invoker.UpdateItem(updatableTodoItem, theItem);
                this.BindTodoItems();

                this.todoItem.Text = string.Empty;
                this.todoItem.Focus();
            }
            else
            {
                this.todoItem.Focus();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (this.todoItem.Text.Trim() == string.Empty)
            //{
            //    return;
            //}

            var selectedItem = this.listBoxTodoItem.SelectedItem.ToString();
            //var text = this.todoItem.Text.Trim();
            var deletableTodoItem = this.todo.todoList.Last(x => x.Item == selectedItem);

            var theItem = new TodoItem
            {
                Id = deletableTodoItem.Id,
                Item = selectedItem
            };

            if (selectedItem != string.Empty)
            {
                //deletableTodoItem.Item = text;
                this.invoker.DeleteItem(deletableTodoItem, theItem);
                this.BindTodoItems();

                this.todoItem.Text = string.Empty;
                this.todoItem.Focus();
            }
            else
            {
                this.todoItem.Focus();
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            this.invoker.Undo();
            this.BindTodoItems();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            this.invoker.Redo();
            this.BindTodoItems();
        }

        private void BindTodoItems()
        {
            this.listBoxTodoItem.DataSource = null;
            this.listBoxTodoItem.DataSource = this.todo.todoList.Select(x => x.Item).ToList();
        }
    }
}
