using Microsoft.AspNetCore.Mvc;
using todo_backend.Models;
using todo_backend.Services.Todos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace todo_backend.Controllers
{
    [Route("v1/api/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodosService _todoservices;
        public TodosController(ITodosService todoservices)
        {
            _todoservices = todoservices;
        }

        // GET: api/<TodosController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_todoservices.GetTodos());
        }

        // GET api/<TodosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TodosController>
        [HttpPost]
        public IActionResult Post(Todo todo)
        {
            return Ok(_todoservices.AddTodo(todo));
        }

        // PUT api/<TodosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TodosController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_todoservices.DeleteTodo(id));
        }
    }
}
