using Snai3i_DAL.Data.Context;
using Snai3i_DAL.Data.Repository.SizesRepository;
using Snai3i_DAL.Data.Repository.ToolsRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_DAL.Data.Repository.UnitOfWork
{
    public class UnitOfWork:IUnitOfWork
    {


        private readonly SnaiiDBContext _context;
        public IToolRepository Toolss { get; private set; }
        public ISizeRepository Sizee { get; private set; }

        //public ICraftRepo Craftt { get; private set; }

        public UnitOfWork(SnaiiDBContext context)
        {
            _context = context;
            Toolss = new ToolRepository(_context);
            Sizee = new SizeRepository(_context);
            //Craftt = new CraftRepo(_context);
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
