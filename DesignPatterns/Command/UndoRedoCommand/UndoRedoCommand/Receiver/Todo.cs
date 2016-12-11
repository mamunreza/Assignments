namespace UndoRedoCommand.Receiver
{
    using System;
    using System.Collections.Generic;

    public class Todo
    {
        public List<TodoItem> todoList = new List<TodoItem>();

        public List<TodoItem> updatedTodos = new List<TodoItem>();
        public List<TodoItem> deletedTodos = new List<TodoItem>();

        public void Add(TodoItem todoItem)
        {
            this.todoList.Add(todoItem);
        }

        public void Remove(Guid id)
        {
            try
            {
                if (this.todoList.Count > 0)
                {
                    this.todoList.Remove(this.todoList.Find(x => x.Id == id));
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(TodoItem todoItem)
        {
            this.updatedTodos.Add(todoItem);
        }

        public void Delete(TodoItem todoItem)
        {
            this.deletedTodos.Add(todoItem);
        }
    }
}