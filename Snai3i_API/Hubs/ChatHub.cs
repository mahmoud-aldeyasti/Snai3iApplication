using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using Snai3i_BLL.DTO;
using Snai3i_BLL.Manager.ChatsManager;
using System.Security.Claims;

namespace Snai3i_API.Hubs
{
	
	public class ChatHub:Hub
    {
		private readonly IChatManager _chatManager;

		public ChatHub(IChatManager chatManager)
		{
			_chatManager = chatManager;
		}
		//string receiverId, string message
		[Authorize]
		public async Task sendmessage(ChatDTO chat)
        {

            var senderId = Context.UserIdentifier; // Get the sender's userId from authentication
			var senderName = Context.User?.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value;
			chat.senderId = senderId;
		  
		   await Clients.Users(senderId, chat.receiverId).SendAsync("newmessage", senderId, chat.message);//it want to tell all online clients that you have a receive message
			await _chatManager.AddChat(chat);
		}


    }
}
