namespace UndoRedoCommand.ConcreteCommand
{
    using UndoRedoCommand.AbstractCommand;
    using UndoRedoCommand.Receiver;

    public class CreateCommand : Command
    {
        private Todo todo;

        private TodoItem todoItem;

        public CreateCommand(Todo todo, TodoItem todoItem)
        {
            this.todo = todo;
            this.todoItem = todoItem;
        }

        public override void Execute()
        {
            this.todo.Add(this.todoItem);
        }

        public override void UnExecute()
        {
            this.todo.Remove(this.todoItem.Id);
        }
    }
}