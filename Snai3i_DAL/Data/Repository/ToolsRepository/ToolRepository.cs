using Microsoft.EntityFrameworkCore;
using Snai3i_DAL.Data.Context;
using Snai3i_DAL.Data.Models;
using Snai3i_DAL.Data.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_DAL.Data.Repository.ToolsRepository
{
    public class ToolRepository : GenericRepository<Tool>, IToolRepository
    {
        private readonly SnaiiDBContext context;

        public ToolRepository(SnaiiDBContext _context) : base(_context)
        {
            context = _context;
        }

        // generic get all async
        //public async Task<IEnumerable<Tool>> GetAllincAsync()
        //{

        //  return await context.tools.Where(a=>a.Id==).Include(a=>a.sizes).ToListAsync();
        //}

    }
}
