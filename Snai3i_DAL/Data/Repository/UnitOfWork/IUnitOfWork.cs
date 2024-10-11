using Snai3i_DAL.Data.Repository.CraftsRepository;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_DAL.Data.Repository.UnitOfWork
{
    public interface IUnitOfWork:IDisposable
    {

        //ToolsRepository Toolss { get; }
        
        ICraftRepo Craftt { get; }

        Task<int> CompleteAsync();
    }
}
