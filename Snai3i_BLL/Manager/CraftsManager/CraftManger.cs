using AutoMapper;
using Snai3i_BLL.DTOS.CraftDto;
using Snai3i_DAL.Data.Models;
using Snai3i_DAL.Data.Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_BLL.Manager.CraftsManager
{
    public class CraftManger : ICraftManger
    {
        private readonly IMapper _mapper;
        //Unit of Work DJ 
        private readonly IUnitOfWork _unitOfWork;
        public CraftManger(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper=mapper;
        }

        //Add Craft 
        public async Task AddCraftAsync(CraftAddDTO craft)
        {
            var craftModel = new Craft()
            {
                CraftName = craft.CraftName,
                createdbyId = craft.createdbyId,
                createdbyName = craft.createdbyName,
                createddatetime = DateTime.Now

            };
            await _unitOfWork.Craftt.InsertAsync(craftModel);
            await _unitOfWork.CompleteAsync();
        }

        //Delet Craft
        public async Task DeleteCraftAsync(int id)
        {
            var CraftModel =  _unitOfWork.Craftt.GetByIdAsync(id);
          await _unitOfWork.Craftt.DeleteAsync(CraftModel);
            await _unitOfWork.CompleteAsync();  
        }

        //Eidet Craft 
        public async Task EidetCraftAsync(CraftUdateDTO craft)
        {
            var CraftModel =await _unitOfWork.Craftt.GetByIdAsync(craft.CraftId);
            CraftModel.CraftName = craft.CraftName;
            CraftModel.modifiedbyId = craft.modifiedbyId;
            CraftModel.modifiedbyName = craft.modifiedbyName;
            CraftModel.modifiedDatetime = DateTime.Now;
            await _unitOfWork.Craftt.UpdateAsync(CraftModel);
            await _unitOfWork.CompleteAsync();
        }

        //Get all Craft 
        public async Task<IEnumerable<CraftReadDTO>> GetAllCraftAsync()
        {
            var CraftModel = await _unitOfWork.Craftt.GetAllAsync();
            var CafteDto = CraftModel.Select(x => new CraftReadDTO() { CraftName = x.CraftName });

            return CafteDto;
            //return _mapper.Map<List<CraftReadDTO>>(await _unitOfWork.Craftt.GetAllAsync())

        }

        //get by Id 
        public async Task<CraftReadDTO> GetCraftByIdAsync(int id)
        {
            var CraftModel = await _unitOfWork.Craftt.GetByIdAsync(id);

            var CraftReadDTo = new CraftReadDTO()
            {
                CraftName = CraftModel.CraftName
            };
            return CraftReadDTo; 
        }
    }
}
