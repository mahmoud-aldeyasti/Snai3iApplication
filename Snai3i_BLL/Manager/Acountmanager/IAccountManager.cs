using Snai3i_BLL.DTO.AcountDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_BLL.Manager.Acountmanager
{
    public interface IAccountManager
    {
        Task<GeneralResponse> login(loginDTO log);

        Task<GeneralResponse> RegisterUser(UserRegisterDto userRegisterDto);
        Task<GeneralResponse> RegisterWorker(WorkerRegisterDto WorkerRegisterDto);
    }
}
