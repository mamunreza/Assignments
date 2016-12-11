namespace UndoRedoCommand.ConcreteCommand
{
    using UndoRedoCommand.AbstractCommand;
    using UndoRedoCommand.Receiver;

    public class UpdateCommand : Command
    {
        private Todo todo;

        private TodoItem todoItem;

        public UpdateCommand(Todo todo, TodoItem todoItem)
        {
            this.todo = todo;
            this.todoItem = todoItem;
        }

        public override void Execute()
        {
            var currentTodo = this.todo.todoList.Find(x => x.Id == this.todoItem.Id);
            currentTodo.Item = this.todoItem.Item;
        }

        public override void UnExecute()
        {
            var currentTodo = this.todo.todoList.Find(x => x.Id == this.todoItem.Id);
            var oldTodo = this.todo.updatedTodos.Find(x => x.Id == this.todoItem.Id);

            if (oldTodo == null)
            {
                return;
            }

            currentTodo.Item = oldTodo.Item;
            this.todo.updatedTodos.Remove(oldTodo);
        }
    }
}