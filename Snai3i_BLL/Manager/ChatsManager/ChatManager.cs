using Microsoft.AspNetCore.Authorization;
using Snai3i_BLL.DTO;
using Snai3i_BLL.DTO.ChatDto;
using Snai3i_BLL.DTO.OrderDto;
using Snai3i_BLL.DTO.CraftDto;
using Snai3i_DAL.Data.Models;
using Snai3i_DAL.Data.Repository.UserWorkerTransactionUnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_BLL.Manager.ChatsManager
{
	
	public class ChatManager : IChatManager
    {
        private readonly IUserWorkerTransactionUnitOfWork _unitOfWork;

        public ChatManager(IUserWorkerTransactionUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
	
		public async Task AddChat(ChatDTO chatDTO)
        {
            var chat = new Chat()
            {
                SenderId = chatDTO.senderId,
                Message = chatDTO.message,
                Date = DateTime.Now,
                ReceiverId = chatDTO.receiverId

            };

            _unitOfWork.CreateTransaction();
           await _unitOfWork.chats.InsertAsync(chat);
           await _unitOfWork.Save();
            _unitOfWork.Commit();
        }
		
		public async Task<IEnumerable<ChatDTO>> getChat(string SenderId ,string ReceiverId)
        {
            _unitOfWork.CreateTransaction();
            var chat = await _unitOfWork.chats.GetMessagesAsync(SenderId, ReceiverId);
            _unitOfWork.Commit();
            return  chat.Select(o => new ChatDTO
            {
                message = o.Message,
                senderId = o.SenderId,
                receiverId = o.ReceiverId,
                
            }).ToList();

        }

        
		public async Task<IEnumerable<ReceiveDto>> getChatbyReceiverId( string ReceiverId)
		{
			_unitOfWork.CreateTransaction();
			var chat = await _unitOfWork.chats.GetMessagesbyreseverAsync(ReceiverId);
			_unitOfWork.Commit();
			return chat.Select(o => new ReceiveDto
			{
				
				senderid = o.SenderId,
				name = o.sender.UserName,

			}).ToList();



		}

		
	}
}
