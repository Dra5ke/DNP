using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Exercise_1_2.Controllers
{
    // [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TodoContext _context;

        public TodoController(TodoContext context)
        {
            _context = context;

            if(_context.TodoItems.Count() == 0)
            {
                _context.TodoItems.Add(new TodoItem { Name = "Item1", id = 1 });
                 _context.TodoItems.Add(new TodoItem { Name = "Item2", id = 2 });
                  _context.TodoItems.Add(new TodoItem { Name = "Item3", id = 3 });
                  
                _context.SaveChanges();
            }
        }

        // GET api/todo
        [HttpGet]
        public ActionResult<IEnumerable<TodoItem>> Get()
        {
            return Ok(_context.TodoItems);
        }

        // GET api/todo/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTodo([FromRoute] int id)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var todo =  await _context.TodoItems.SingleOrDefaultAsync(m => m.id == id);

            if(todo == null)
            {
                return NotFound();
            }

            return Ok(todo);
        }

        // POST api/todo
        [HttpPost]
        public async Task<IActionResult> PostTodo([FromBody] TodoItem todo)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.TodoItems.Add(todo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTodo", new { id = todo.id }, todo);
        }

        // PUT api/todo/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodo([FromRoute] int id, [FromBody] TodoItem todo)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if(id != todo.id)
            {
                return BadRequest($"Route id= {id} does not match actual object id= {todo.id} from body");
            }

            _context.Entry(todo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException)
            {
                if(!TodoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodo([FromRoute] int id)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var todo = await _context.TodoItems.SingleOrDefaultAsync(m => m.id == id);
            if(todo == null)
            {
                return NotFound();
            }

            _context.TodoItems.Remove(todo);
            await _context.SaveChangesAsync();

            return Ok(todo);

        }

        private bool TodoExists(int id)
        {
            return _context.TodoItems.Any(e => e.id == id);
        }
    }
}
