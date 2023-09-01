using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestRBackend.Models;

namespace TestRBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class User_RobertoEscobarController : ControllerBase
    {
        private readonly TestContext _context;

        public User_RobertoEscobarController(TestContext context)
        {
            _context = context;
        }

        // GET: api/User_RobertoEscobar
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User_RobertoEscobar>>> GetUser_RobertoEscobars()
        {
          if (_context.User_RobertoEscobars == null)
          {
              return NotFound();
          }
            return await _context.User_RobertoEscobars.ToListAsync();
        }

        // GET: api/User_RobertoEscobar/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User_RobertoEscobar>> GetUser_RobertoEscobar(int id)
        {
          if (_context.User_RobertoEscobars == null)
          {
              return NotFound();
          }
            var user_RobertoEscobar = await _context.User_RobertoEscobars.FindAsync(id);

            if (user_RobertoEscobar == null)
            {
                return NotFound();
            }

            return user_RobertoEscobar;
        }

        // PUT: api/User_RobertoEscobar/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser_RobertoEscobar(int id, User_RobertoEscobar user_RobertoEscobar)
        {
            if (id != user_RobertoEscobar.Id)
            {
                return BadRequest();
            }

            _context.Entry(user_RobertoEscobar).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!User_RobertoEscobarExists(id))
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

        // POST: api/User_RobertoEscobar
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<User_RobertoEscobar>> PostUser_RobertoEscobar(User_RobertoEscobar user_RobertoEscobar)
        {
          if (_context.User_RobertoEscobars == null)
          {
              return Problem("Entity set 'TestContext.User_RobertoEscobars'  is null.");
          }
            _context.User_RobertoEscobars.Add(user_RobertoEscobar);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser_RobertoEscobar", new { id = user_RobertoEscobar.Id }, user_RobertoEscobar);
        }

        // DELETE: api/User_RobertoEscobar/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser_RobertoEscobar(int id)
        {
            if (_context.User_RobertoEscobars == null)
            {
                return NotFound();
            }
            var user_RobertoEscobar = await _context.User_RobertoEscobars.FindAsync(id);
            if (user_RobertoEscobar == null)
            {
                return NotFound();
            }

            _context.User_RobertoEscobars.Remove(user_RobertoEscobar);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool User_RobertoEscobarExists(int id)
        {
            return (_context.User_RobertoEscobars?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
