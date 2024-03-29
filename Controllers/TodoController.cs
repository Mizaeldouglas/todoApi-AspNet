using Microsoft.AspNetCore.Mvc;
using todoApi.Data;
using todoApi.Models;

namespace todoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {

        private readonly AppDbContext _context;

        public TodoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_context.Todos.ToList());

        [HttpPost]
        public IActionResult Post(Todo todo)
        {
            _context.Todos.Add(todo);
            _context.SaveChanges();

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (_context.Todos == null)
            {
                return NotFound();
            }
            var todo = _context.Todos.Find(id);

            if (todo == null)
            {
                return NotFound();
            }

            return Ok(todo);
        }
       

    }
}