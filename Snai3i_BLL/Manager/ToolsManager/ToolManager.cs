using AutoMapper;
using Microsoft.AspNetCore.Http;
using Snai3i_BLL.DTO.AcountDto;
using Snai3i_BLL.DTO.ToolsDTO;
using Snai3i_DAL.Data.Models;
using Snai3i_DAL.Data.Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Snai3i_BLL.Manager.ToolsManager
{
    public class ToolManager : IToolManager
    {
        // D J
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _IMapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ToolManager(IUnitOfWork unitOfWork, IMapper mapper ,IHttpContextAccessor httpContextAccessor  )
        {
            _unitOfWork = unitOfWork;
            _IMapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }


        //Add Tool 
        public async Task AddAsync(AddToolDTO toolAddDTO)
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var userName = _httpContextAccessor.HttpContext.User.Identity.Name;
           // var imageresult = _fileservice.SaveImage(userRegisterDto.imageFile);
            var ToolModel = new Tool()
            {
                Name = toolAddDTO.Name,
                Image = toolAddDTO.Image,
                Description = toolAddDTO.Description,
                createdbyId = userId,
                createddatetime = DateTime.Now,
                createdbyName = userName

            };

            await _unitOfWork.Toolss.InsertAsync(ToolModel);
            //await _unitOfWork.Toolss.InsertAsync(_IMapper.Map<Tool>(toolAddDTO));
            await _unitOfWork.CompleteAsync();
        }


        //Delete Tool 
        public async Task DeleteAsync(int id)
        {
            var ToolModel = await _unitOfWork.Toolss.GetByIdAsync(id);
            ToolModel.deletedbyId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            ToolModel.deleteddatetime = DateTime.Now;
           
            await _unitOfWork.Toolss.DeleteAsync(id);
            await _unitOfWork.CompleteAsync();
        }


        //Get All Tool 
        public async Task<IEnumerable<ReadToolDTO>> GetAllAsync()
        {
            //var ToolModel = await _unitOfWork.Toolss.GetAllincAsync();
            //var toolReadDTo = new ReadToolDTO()
            //{

            //    Name = ToolModel.Name,
            //    Image = ToolModel.Image,
            //    Description = ToolModel.Description,

            //};
            // return toolReadDTo;

            return _IMapper.Map<List<ReadToolDTO>>(await _unitOfWork.Toolss.GetAllAsync(null, "sizes"));
        }


        // Get By Id
        public async Task<ReadToolDTO> GetByIdAsync(int id)
        {
            return _IMapper.Map<ReadToolDTO>(await _unitOfWork.Toolss.GetByIdAsync(id));
        }


        //Update Tool 
        public async Task UpdateAsync(UpdateToolDTO updateToolDTO)
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var userName = _httpContextAccessor.HttpContext.User.Identity.Name;

            var ToolModel = await _unitOfWork.Toolss.GetByIdAsync(updateToolDTO.Id);
            ToolModel.Name = updateToolDTO.Name;
            ToolModel.Image = updateToolDTO.Image;
            ToolModel.Description = updateToolDTO.Description;
            ToolModel.modifiedDatetime = DateTime.Now;
            ToolModel.modifiedbyName = userName;
            ToolModel.modifiedbyId = userId;
            //_IMapper.Map<ToolUpdateDTO, Tool>(toolUpdateDTO, await _unitOfWork.Toolss.GetByIdAsync(toolUpdateDTO.Id)) 
            await _unitOfWork.Toolss.UpdateAsync(ToolModel);
            await _unitOfWork.CompleteAsync();
        }



    }
}
