using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence;

namespace API.Controllers
{
    public class ManualsController : BaseAPIController
    {
        private readonly DataContext _context;

        public ManualsController(DataContext context)
        {
            this._context = context;
        }

        [HttpGet(Name = "GetManuals")]
        public async Task<ActionResult<List<Manual>>> GetManuals()
        {
            return await _context.Manuals.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Manual>> GetManual(Guid id)
        {
            return await _context.Manuals.FindAsync(id);
        }


    }
}