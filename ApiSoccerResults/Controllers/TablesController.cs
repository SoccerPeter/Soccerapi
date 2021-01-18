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
    
    public class TablesController : ControllerBase
    {
        private readonly dbAppContext _context;

        public TablesController(dbAppContext context)
        {
            _context = context;
        }

        // GET: api/Tables/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<TbLeagueStanding>>> GetTbLeagueStanding(int id)
        {
            var tbLeagueStanding = from T in _context.TbLeagueStandings
                                   where T.LigId == id
                                   select T;

            if (tbLeagueStanding == null)
            {
                return NotFound();
            }

            return await tbLeagueStanding.ToListAsync();
        }

        [HttpGet("{Country}/{Legue}")]
        public async Task<ActionResult<IEnumerable<Ligor>>> getLegueId(string Country, string Legue)
        {
            var LegueID = from T in _context.Ligors
                          where T.Country == Country && T.Name == Legue
                          select  T;

            return await LegueID.ToListAsync();
        }

        
    }
}
