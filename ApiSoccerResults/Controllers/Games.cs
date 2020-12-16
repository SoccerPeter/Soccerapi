using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiSoccerResults.Models;

namespace ApiSoccerResults.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Games : ControllerBase
    {
        private readonly dbAppContext _context;

        public Games(dbAppContext context)
        {
            _context = context;
        }

        // GET: api/Games
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fixture>>> GetFixtures( DateTime Datum)
        {
           
            return await _context.Fixtures.ToListAsync();
        }

        // GET: api/Games/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Fixture>> GetFixture(int id)
        {
            var fixture = await _context.Fixtures.FindAsync(id);

            if (fixture == null)
            {
                return NotFound();
            }

            return fixture;
        }

        // PUT: api/Games/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFixture(int id, Fixture fixture)
        {
            if (id != fixture.Idnr)
            {
                return BadRequest();
            }

            _context.Entry(fixture).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FixtureExists(id))
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

        // POST: api/Games
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Fixture>> PostFixture(Fixture fixture)
        {
            _context.Fixtures.Add(fixture);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFixture", new { id = fixture.Idnr }, fixture);
        }

        // DELETE: api/Games/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Fixture>> DeleteFixture(int id)
        {
            var fixture = await _context.Fixtures.FindAsync(id);
            if (fixture == null)
            {
                return NotFound();
            }

            _context.Fixtures.Remove(fixture);
            await _context.SaveChangesAsync();

            return fixture;
        }

        private bool FixtureExists(int id)
        {
            return _context.Fixtures.Any(e => e.Idnr == id);
        }
    }
}
