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
    
    public class LigorController : ControllerBase
    {
        private readonly dbAppContext _context;

        public LigorController(dbAppContext context)
        {
            _context = context;
        }

        // GET: api/Ligor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ligor>>> GetLigors()
        {
            var Legues = from L in _context.Ligors
                         select L;
                         
            return await Legues.ToListAsync();
        }

      

        private bool LigorExists(int id)
        {
            return _context.Ligors.Any(e => e.Id1 == id);
        }
    }
}
