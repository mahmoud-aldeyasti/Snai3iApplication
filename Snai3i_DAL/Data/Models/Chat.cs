using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_DAL.Data.Models
{
    public class Chat :  Deletebase , Isoftdelete
    {
        public int SenderId { get; set; }

        public int ReceiverId { get; set; }

        public DateTime Date { get; set; }

        public string Message { get; set; }

        public User user { get; set; } = new User();

        public Worker worker { get; set; }  = new Worker();

    }
}
