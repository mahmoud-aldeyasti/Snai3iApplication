using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_DAL.Data.Models
{
    public class Review : Deletebase, Isoftdelete
    {
        public int UsertId { get; set; }

        public int WorkerId { get; set; }

        public float Rate { get; set; }

        public string Comment { get; set; } 

        public int OrderNumber { get; set; }


        public User user { get; set; } = new User();
        public Worker worker { get; set; } = new Worker();

        public Order order { get; set; } = new Order();

        public ICollection<Card> cards { get; set; } = new HashSet<Card>();
    }
}
