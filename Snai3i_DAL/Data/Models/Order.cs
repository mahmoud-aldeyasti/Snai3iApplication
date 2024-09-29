﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_DAL.Data.Models
{
    public class Order : Deletebase, Isoftdelete
    {
        public int Id { get; set; }

        public DateTime ForwardDate { get; set; }

        public DateTime ConfirmDate { get; set; }

        public double Value { get; set; }

        public double Commision { get; set; }

        public int reviewId { get; set; }

        public Review review { get; set; }


    }
}
