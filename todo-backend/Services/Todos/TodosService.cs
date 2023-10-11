using todo_backend.Data;
using todo_backend.Models;

namespace todo_backend.Services.Todos
{
    public class TodosService : ITodosService
    {
        private readonly TodosDbContext _todosDbContext;
        public TodosService (TodosDbContext todoDbContext)
        {
            _todosDbContext = todoDbContext; 
        }

        public bool AddTodo(Todo todo)
        {
            _todosDbContext.Todos.Add(todo);
            _todosDbContext.SaveChanges();
            return true;
        }

        public bool DeleteTodo(int id)
        {
            Todo todo = _todosDbContext.Todos.Find(id);
            _todosDbContext.Todos.Remove(todo);
            _todosDbContext.SaveChanges();

            return true;
        }

        public List<Todo> GetTodos()
        {
            return _todosDbContext.Todos.OrderByDescending(x => x.Id).ToList();
        }

        public bool UpdateTodo(Todo todo)
        {
            throw new NotImplementedException();
        }
    }
}
