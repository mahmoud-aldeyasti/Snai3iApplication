using Snai3i_DAL.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Snai3i_DAL.Data.Repository;
using Snai3i_DAL.Data.Repository.CraftsRepository;

namespace Snai3i_DAL.Data.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {


        private readonly SnaiiDBContext _context;
        

        public ICraftRepo Craftt { get; private set; }

        public UnitOfWork(SnaiiDBContext context) 
        {
            _context=context;
            
            Craftt = new CraftRepo(_context);
        }


        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

       
    }
}
