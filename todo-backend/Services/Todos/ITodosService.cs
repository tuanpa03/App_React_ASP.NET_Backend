using todo_backend.Models;

namespace todo_backend.Services.Todos
{
    public interface ITodosService
    {
        List<Todo> GetTodos(); //laays todo
        Boolean AddTodo(Todo todo);
        Boolean UpdateTodo(Todo todo);
        Boolean DeleteTodo(Todo todo);
    }
}
