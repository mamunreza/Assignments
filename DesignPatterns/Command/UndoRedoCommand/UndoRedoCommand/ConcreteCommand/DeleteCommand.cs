namespace UndoRedoCommand.ConcreteCommand
{
    using UndoRedoCommand.AbstractCommand;
    using UndoRedoCommand.Receiver;

    public class DeleteCommand : Command
    {
        private Todo todo;

        private TodoItem todoItem;

        public DeleteCommand(Todo todo, TodoItem todoItem)
        {
            this.todo = todo;
            this.todoItem = todoItem;
        }

        public override void Execute()
        {
            var currentTodo = this.todo.todoList.Find(x => x.Id == this.todoItem.Id);
            this.todo.todoList.Remove(currentTodo);
        }

        public override void UnExecute()
        {
            var oldTodo = this.todo.deletedTodos.Find(x => x.Id == this.todoItem.Id);

            if (oldTodo == null)
            {
                return;
            }

            var redoTodo = new TodoItem
                               {
                                   Id = oldTodo.Id,
                                   Item = oldTodo.Item
                               };

            this.todo.todoList.Add(redoTodo);
            this.todo.deletedTodos.Remove(oldTodo);
        }
    }
}