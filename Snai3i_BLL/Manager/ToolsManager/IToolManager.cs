using Snai3i_BLL.DTO.ToolsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_BLL.Manager.ToolsManager
{
    public interface IToolManager
    {

        Task<IEnumerable<ReadToolDTO>> GetAllAsync();

        Task<ReadToolDTO> GetByIdAsync(int id);
        
        public Task AddAsync(AddToolDTO toolAddDTO);

        public Task UpdateAsync(UpdateToolDTO updateToolDTO);

        public Task DeleteAsync(int id);

        //public Task<ToolReadDTo> GetToolByNameAsync(string name);

        //public Task<IEnumerable<ToolReadDTo>> GetToolsByPriceRangeAsync(decimal minPrice, decimal maxPrice);


    }
}
