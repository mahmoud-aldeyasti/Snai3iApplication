using Microsoft.AspNetCore.Http;
using Snai3i_BLL.DTO.SizesDTO;
using Snai3i_DAL.Data.Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_BLL.Manager.SizesManager
{
    public class SizeManager : ISizeManager
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public SizeManager(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
        }

        public Task AddAsync(AddSizeDTO addSizeDTO)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ReadSizeDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ReadSizeDTO> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(UpdateSizeDTO updateSizeDTO)
        {
            throw new NotImplementedException();
        }
    }
}
