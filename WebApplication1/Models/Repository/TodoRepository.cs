namespace WebApplication1.Models.Repository
{
    public static class TodoRepository
    {
        private static List<Todo> _todo = new List<Todo>();

        public static List<Todo> GetTodos()
        {
            return _todo;
        }
        public static void AddTodo(Todo todo)
        {
            _todo.Add(todo);
        }
        
    }
}
