using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PartageMemoireGatewaye.Models;

namespace PartageMemoireGatewaye.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class User1Controller : ControllerBase
    {
        private readonly AppDbContext _context;

        public User1Controller(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/User1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User1>>> Getusers()
        {
            return await _context.users.ToListAsync();
        }

        // GET: api/User1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User1>> GetUser1(int id)
        {
            var user1 = await _context.users.FindAsync(id);

            if (user1 == null)
            {
                return NotFound();
            }

            return user1;
        }

        // PUT: api/User1/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser1(int id, User1 user1)
        {
            if (id != user1.Id)
            {
                return BadRequest();
            }

            _context.Entry(user1).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!User1Exists(id))
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

        // POST: api/User1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<User1>> PostUser1(User1 user1)
        {
            _context.users.Add(user1);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser1", new { id = user1.Id }, user1);
        }

        // DELETE: api/User1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser1(int id)
        {
            var user1 = await _context.users.FindAsync(id);
            if (user1 == null)
            {
                return NotFound();
            }

            _context.users.Remove(user1);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool User1Exists(int id)
        {
            return _context.users.Any(e => e.Id == id);
        }
    }
}
