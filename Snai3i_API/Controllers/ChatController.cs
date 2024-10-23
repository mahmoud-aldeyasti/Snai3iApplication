using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Snai3i_BLL.DTO;
using Snai3i_BLL.DTO.ToolsDTO;
using Snai3i_BLL.Manager.ChatsManager;
using System.Security.Claims;

namespace Snai3i_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IChatManager _chatManager;

        public ChatController(IChatManager chatManager)
        {
            _chatManager = chatManager;
        }



        [HttpPost]
        public async Task<IActionResult> addChat(ChatDTO AddDTO)
        {
                await _chatManager.AddChat(AddDTO);
                return Ok("Chat Added Successfully");  
        }


        [HttpGet]
        public async Task<IActionResult> getChat(string SenderId, string ReceiverId)
        {
          var mo =  await _chatManager.getChat(SenderId,ReceiverId);
            return Ok(mo);
        }

		[HttpGet("getChatbyRecevir")]
		public async Task<IActionResult> getChatbyRecevir( string ReceiverId)
		{
			var mo = await _chatManager.getChatbyReceiverId( ReceiverId);
			return Ok(mo);
		}

	}
}
