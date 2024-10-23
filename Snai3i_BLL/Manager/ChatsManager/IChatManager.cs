using Snai3i_BLL.DTO;
using Snai3i_BLL.DTO.ChatDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_BLL.Manager.ChatsManager
{
    public interface IChatManager
    {


        public Task AddChat(ChatDTO chatDTO);

        public Task<IEnumerable<ChatDTO>> getChat(string SenderId, string ReceiverId); 
        public Task<IEnumerable<ReceiveDto>> getChatbyReceiverId( string ReceiverId); 

	}
}
