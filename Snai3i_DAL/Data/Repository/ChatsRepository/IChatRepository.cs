using Snai3i_DAL.Data.Models;
using Snai3i_DAL.Data.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_DAL.Data.Repository.ChatsRepository
{
    public interface IChatRepository:IGenericRepository<Chat>
    {


        Task<IReadOnlyList<Chat>> GetMessagesAsync(string SenderId, string receiverId); 

        Task<IReadOnlyList<Chat>> GetMessagesbyreseverAsync( string receiverId);





	}
}
