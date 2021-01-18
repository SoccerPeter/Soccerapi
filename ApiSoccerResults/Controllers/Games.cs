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
    [ApiController]
    [Route("api/[controller]")]
    
    public class Games : ControllerBase
    {
        private readonly dbAppContext _context;

        public Games(dbAppContext context)
        {
            _context = context;
        }

        // GET: api/Games
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fixture>>> GetFixtures(DateTime Datum)
        {
            DateTime datum = Datum;

            var resultatIdag = from a in _context.Fixtures
                               where a.Date >= Datum
                               where a.Date <= Datum.AddDays(1)
                               select a;

            return await resultatIdag.ToListAsync();
        }

        private bool FixtureExists(int id)
        {
            return _context.Fixtures.Any(e => e.Idnr == id);
        }
    }
}
