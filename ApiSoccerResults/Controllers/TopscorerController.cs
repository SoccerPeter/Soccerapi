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
    
    public class TopscorerController : ControllerBase
    {
        private readonly dbAppContext _context;

        public TopscorerController(dbAppContext context)
        {
            _context = context;
        }

        // GET: api/Topscorer
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<TopScorer>>> GetTopScorers(int id)
        {
            var Top = from T in _context.TopScorers
                      where T.LegueId == id
                      select T;

            return await Top.ToListAsync();
        }
        

        private bool TopScorerExists(int id)
        {
            return _context.TopScorers.Any(e => e.Id == id);
        }
    }
}
