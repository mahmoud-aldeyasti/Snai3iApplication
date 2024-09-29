﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_DAL.Data.Models
{
    public class User : ApplicationUser , Isoftdelete
    {

        public double Longitude { get; set; }
        public double Latitude { get; set; }

        public  ICollection<Worker> workers { get; set; } = new HashSet<Worker>();

        public ICollection<Review> reviews { get; set; } = new HashSet<Review>();

        public ICollection<Chat> chats { get; set; } = new HashSet<Chat>();

        public ICollection<Tool> tools { get; set; } = new HashSet<Tool>();

        public ICollection<Card> cards { get; set; } = new HashSet<Card>();



    }
}
