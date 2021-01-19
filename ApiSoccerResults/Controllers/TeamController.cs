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
    
    public class TeamController : ControllerBase
    {
        private readonly dbAppContext _context;

        public TeamController(dbAppContext context)
        {
            _context = context;
        }

        // GET: api/Team/1360
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<TbTeam>>> GetTbTeams(int id)
        {
            var Top = from T in _context.TbTeams
                      where T.LegueId == id
                      select T;

            return await Top.ToListAsync();
        }

        private bool TbTeamExists(int id)
        {
            return _context.TbTeams.Any(e => e.Id == id);
        }
    }
}
