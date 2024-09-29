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

        public usertype SenderType { get; set; }
        public ApplicationUser sender { get; set; } = new ApplicationUser();

        public usertype ReceiverType { get; set; }
        public int ReceiverId { get; set; }
        public ApplicationUser receiver { get; set; } = new ApplicationUser();

        public DateTime Date { get; set; }
        public string Message { get; set; }

    }
}
