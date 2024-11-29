using Microsoft.EntityFrameworkCore;
using Snai3i_DAL.Data.Context;
using Snai3i_DAL.Data.Models;
using Snai3i_DAL.Data.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_DAL.Data.Repository.CardRepository
{
    public class CartRebo : GenericRepository<Card>, ICartRebo
    {


        public CartRebo(SnaiiDBContext context) : base(context)
        {

        }


        public async Task<IEnumerable<Card>> GetAllCart()
        {
            return await Context.cards
                           .Include(c => c.tool)
                          
                           .Include(c => c.size)
                           .Include(c => c.buyer)
            .ToListAsync();
        }

        public async Task<Card> GetByIdCart(int id)
        {
            return await Context.cards
                                       .Include(c => c.tool)
                       
                           .Include(c => c.size)
                           .Include(c => c.buyer)
                                       .FirstOrDefaultAsync(c => c.Id == id);

        }

        public async Task<IEnumerable<Card>> GetCardbybuyer(string Id)
        {
            return await Context.cards.Include(c => c.tool)
                           
                           .Include(c => c.size)
                           .Include(c => c.buyer).Where(a=> a.BuyerId == Id).ToListAsync();
        }

        public async Task<Card> GetCardByUseAndTool(string buyerId, int ToolId)
        {
            return await Context.cards
                           .FirstOrDefaultAsync(a => a.BuyerId == buyerId && a.ToolId==ToolId);
        }

        public int IncreaseCount(Card card, int count)
        {
            card.Quantity += count;
            return card.Quantity;
        }



        public int DecreaseCount(Card card, int count)
        {
            card.Quantity -= count;
            return card.Quantity;
        }

		public async Task<IEnumerable<Card>> GetAllCardsAsync(string buyerId)
		{
			return await Context.cards
		  .Include(c => c.tool)
		  .Include(c => c.size)
		  
		  .Where(c => c.BuyerId == buyerId)
		  .ToListAsync();
		}

		public async Task AddCardAsync(Card card)
		{
			await Context.cards.AddAsync(card);
			await Context.SaveChangesAsync();
		}

		public async Task RemoveCardAsync(int cardId)
		{
			var card = await Context.cards.FindAsync(cardId);
			if (card != null)
			{
				Context.cards.Remove(card);
				await Context.SaveChangesAsync();
			}
		}

		public async Task<Card> GetCardByIdAsync(int cardId)
		{
			return await Context.cards
		   .Include(c => c.tool)
		   .Include(c => c.size)
		   
		   .FirstOrDefaultAsync(c => c.Id == cardId);
		}
	}
}
