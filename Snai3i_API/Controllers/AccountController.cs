using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Snai3i_BLL.DTO.AcountDto;
using Snai3i_BLL.Manager.Acountmanager;
using Snai3i_DAL.Data.service.FileService;
using Microsoft.AspNetCore.Http;
using Snai3i_BLL.DTO.WorkerDto;
using Snai3i_BLL.Manager.WorkerManager;
using Snai3i_DAL.Data;
using Snai3i_BLL.Manager.UserManager;

namespace Snai3i_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AccountController : ControllerBase
    {
        private readonly IAccountManager accountManager;
        

        public AccountController(IAccountManager accountManager , Ifileservice ifileservice )
            
        {
            this.accountManager = accountManager;
            
        }



        [AllowAnonymous]
        [HttpPost]
        [Route("Register")]
        public async Task<ActionResult> Register([FromForm] RegisterDto Register)
        {
            var result = await accountManager.Register(Register);
            return Ok(result);
        }


        [AllowAnonymous]
        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult> Login(LoginDTO log)
        {
            var result = await accountManager.login(log);
            return Ok(result);
        }


        [HttpGet("SignOut")]

        public async Task<IActionResult> SignOut()
        {
            await accountManager.signout();
            return Ok(new { message = "User signed out successfully." });
        }


        [HttpGet("GetByIdAsync")]

        public async Task<IActionResult> GetByIdAsync(string id)
        {
            return Ok(await accountManager.GetByIdAsync(id));
        }


        [HttpGet("GetByIdMailAsync")]

        public async Task<IActionResult> GetByIdMailAsync(string mail)
        {
            return Ok(await accountManager.GetByIdMailAsync(mail));
        }

        [HttpGet]
        [Route("{user_Id}")]
        public async Task<IActionResult> Edit(string user_Id)
        {
            var appuser = await accountManager.Edit(user_Id); 
            if (appuser == null)
            {
                return NotFound($"user with id : {user_Id} can't be found ");
            }
            return Ok(appuser);
        }



        [HttpPut("Edit/{user_Id}")]
        public async Task<IActionResult> Edit(string user_Id,[FromForm] ApplicationUserEditDto appuserEdit)
        {
            if( user_Id == null)
            {
                return NotFound($"user with Id : {user_Id} is not found ");
            }
            if(user_Id != appuserEdit.userId)
            {
                return BadRequest("check you are updating the right application user ");
            }

            ; 

            return Ok(await accountManager.Edit(appuserEdit));

        }


        [HttpGet("ChangePassword")]

        public async Task<IActionResult> ChangePassword()
        {
            return Ok();
        }

        [HttpPost("ChangePassword")]
        public async Task<IActionResult> ChangePassword(ChangePasswordDto changePassword)
        {
            var loginuser = await accountManager.ChangePasswordAsync(changePassword);
            if (loginuser == null)
            {

                return NotFound();
            }

            return Ok (loginuser);
        }



    }


}