using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Snai3i_BLL.DTO.AcountDto;
using Snai3i_BLL.Manager.Acountmanager;
using Snai3i_DAL.Data.Repository.service;

namespace Snai3i_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountManager accountManager;


        public AccountController(IAccountManager accountManager , Ifileservice ifileservice)
        {
            this.accountManager = accountManager;

        }
        [HttpPost]
        [Route("RegisterWorkder")]
        public async Task<ActionResult> registerWorker([FromForm] WorkerRegisterDto workerRegister)
        {
            var result = await accountManager.RegisterWorker(workerRegister);

            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }

        [HttpPost]
        [Route("RegisterUser")]
        public async Task<ActionResult> registerUser([FromForm] UserRegisterDto userRegister)
        {
            var result = await accountManager.RegisterUser(userRegister);

            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }

        [HttpPost]
        [Route("Login")]

        public async Task<ActionResult> Login(loginDTO log)
        {
            var result = await accountManager.login(log);

            if (result == null)
            {
                return Unauthorized();
            }
            return Ok(result);
        }
    }
}