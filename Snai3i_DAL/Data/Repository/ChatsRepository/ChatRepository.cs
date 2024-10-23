using Microsoft.EntityFrameworkCore;
using Snai3i_DAL.Data.Context;
using Snai3i_DAL.Data.Models;
using Snai3i_DAL.Data.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_DAL.Data.Repository.ChatsRepository
{
    public class ChatRepository : GenericRepository<Chat>, IChatRepository
    {
        private readonly SnaiiDBContext context;
        public ChatRepository(SnaiiDBContext _context) : base(_context)
        {
            context = _context;
        }


        public async Task<IReadOnlyList<Chat>> GetMessagesAsync(string SenderId, string receiverId)
        {

            return await context.chats
          .Where(m => (m.SenderId == SenderId && m.ReceiverId == receiverId) ||
                      (m.SenderId == receiverId && m.ReceiverId == SenderId))
          .OrderBy(m => m.Date).Include(a=>a.sender).Include(a => a.receiver).AsNoTracking()
		  .ToListAsync();

        }

        public async Task<IReadOnlyList<Chat>> GetMessagesbyreseverAsync( string receiverId)
        {

            return await context.chats
          .Where(m => ( m.ReceiverId == receiverId) ||
                      (m.SenderId == receiverId ))
		  .OrderBy(m => m.Date).Include(a => a.sender).AsNoTracking()
		  .ToListAsync();

        }


    }
}
