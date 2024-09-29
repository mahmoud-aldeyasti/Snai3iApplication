using Microsoft.EntityFrameworkCore;
using Snai3i_DAL.Data.Context;
using Snai3i_DAL.Data.Models;
using Snai3i_DAL.Data.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_DAL.Data.Repository.SalesRepository
{
    public class SalesRepository : GenericRepository<Sales>, IsalesRepository
    {
        public SalesRepository(SnaiiDBContext _context ) : base( _context)
        {
            
        }


        public async Task<IEnumerable<Sales>> GetAllSalesAsync()
        {
            return await Context.sales.Include( a => a.card ).AsNoTracking().ToListAsync();
        }

        public async Task<Sales?> GetSalesByIDAsync(int id)
        {
            return await Context.sales.Include(a => a.card).FirstAsync(a=> a.Id  == id) ; 
        }

    }
}
