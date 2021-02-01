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
    
    public class LineupController : ControllerBase
    {
        private readonly dbAppContext _context;

        public LineupController(dbAppContext context)
        {
            _context = context;
        }


        // GET: api/Lineup/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbLineUp>> GetTbLineUp(int id)
        {
            var tbLineUp = await _context.TbLineUps.FindAsync(id);

            if (tbLineUp == null)
            {
                return NotFound();
            }

            return tbLineUp;
        }

    }
}
