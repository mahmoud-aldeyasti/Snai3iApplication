using Snai3i_DAL.Data.Repository.SizesRepository;
using Snai3i_DAL.Data.Repository.ToolsRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_DAL.Data.Repository.UnitOfWork
{
    public interface IUnitOfWork:IDisposable
    {


        IToolRepository Toolss { get; }
        //   ICraftRepo Craftt { get; }
        ISizeRepository Sizee { get; }
        Task<int> CompleteAsync();


    }
}
