using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Dotnetimals.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatsController : ControllerBase
    {
        private readonly DbRepository _context;
        public CatsController(DbRepository context)
        {
            _context = context;
        }

        // GET api/cats
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_context.GetAllCats());
        }

        // GET api/cats/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "cat";
        }

        // POST api/cats
        [HttpPost]
        public IActionResult PostCat([FromBody] Cat cat)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.AddCat(cat);
            _context.SaveAll();

            return CreatedAtAction("PostCat", new { id = cat.Id}, cat);
        }

        // PUT api/cats/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody] string cat)
        // {
        // }

        // // DELETE api/cats/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        // }
    }
}
