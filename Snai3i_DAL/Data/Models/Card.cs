using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_DAL.Data.Models
{
    public class Card : Deletebase , Isoftdelete
    {
        public int CardId { get; set; }

        public int ToolId { get; set; }

        public  int SizeId { get; set; }

        public int BuyerId { get; set; }

        public int Quantity { get; set; }

        public User User { get; set; } = new User();    
         
        public Worker Worker { get; set; } = new Worker();  

    }
}
