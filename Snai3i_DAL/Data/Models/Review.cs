using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_DAL.Data.Models
{
    public class Review : Deletebase, Isoftdelete
    {
        public int Id { get; set; }
        public int UsertId { get; set; }
        public User user { get; set; } = new User();

        public int WorkerId { get; set; }
        public Worker worker { get; set; } = new Worker();

        public float Rate { get; set; }

        public string Comment { get; set; }

        public int OrderId { get; set; }

        public Order order { get; set; } = new Order();
    }
}
