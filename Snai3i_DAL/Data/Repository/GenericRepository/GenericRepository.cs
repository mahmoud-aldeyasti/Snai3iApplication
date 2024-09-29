using Microsoft.EntityFrameworkCore;
using Snai3i_DAL.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_DAL.Data.Repository.GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly SnaiiDBContext Context;

        protected readonly DbSet<T> table;
        public GenericRepository(SnaiiDBContext _context)
        {
            Context = _context;
            table = _context.Set<T>();
        }

        // generic get all async
        public async Task<IEnumerable<T>> GetAllAsync()
        {

            return await table.AsNoTracking().ToListAsync();
        }

        // generic getbyid async 

        public async Task<T?> GetByIdAsync(object id)
        {
            return await table.FindAsync(id);
        }// generic insert async 

        public async Task InsertAsync(T entity)
        {
            await table.AddAsync(entity);
        }

        // generic update async 

        public async Task UpdateAsync(T entity)
        {
            table.Update(entity);
        }

        // generic delete async 
        public async Task DeleteAsync(object id)
        {
            var entity = await GetByIdAsync(id);

            if (entity != null)
            {
                table.Remove(entity);
            }
        }

        // generic saveasync 
        public async Task saveAsync()
        {
            await Context.SaveChangesAsync();
        }

    }
}
