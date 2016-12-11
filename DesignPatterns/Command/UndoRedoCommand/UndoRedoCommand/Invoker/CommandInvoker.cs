namespace UndoRedoCommand.Invoker
{
    using System.Collections.Generic;
    using System.Windows.Input;

    using UndoRedoCommand.AbstractCommand;
    using UndoRedoCommand.ConcreteCommand;
    using UndoRedoCommand.Receiver;

    public class CommandInvoker
    {
        private Stack<Command> undocommands = new Stack<Command>();
        private Stack<Command> redocommands = new Stack<Command>();

        private Todo todo;

        public CommandInvoker(Todo todo)
        {
            this.todo = todo;
        }

        public void Undo()
        {
            if (this.undocommands.Count != 0)
            {
                Command command = this.undocommands.Pop();
                command.UnExecute();
                this.redocommands.Push(command);
            }
        }

        public void Redo()
        {
            if (this.redocommands.Count != 0)
            {
                Command command = this.redocommands.Pop();
                command.Execute();
                this.undocommands.Push(command);
            }
        }

        public void AddItem(TodoItem item)
        {
            CreateCommand createCommand = new CreateCommand(this.todo, item);
            createCommand.Execute();
            this.undocommands.Push(createCommand);
            this.redocommands.Clear();
        }

        public void UpdateItem(TodoItem updatedItem, TodoItem oldItem)
        {
            UpdateCommand updateCommand = new UpdateCommand(this.todo, updatedItem);
            updateCommand.Execute();
            this.undocommands.Push(updateCommand);
            this.redocommands.Clear();
            this.todo.updatedTodos.Add(oldItem);
        }

        public void DeleteItem(TodoItem deletedItem, TodoItem oldItem)
        {
            DeleteCommand deleteCommand = new DeleteCommand(this.todo, deletedItem);
            deleteCommand.Execute();
            this.undocommands.Push(deleteCommand);
            this.redocommands.Clear();
            this.todo.deletedTodos.Add(oldItem);
        }
    }
}