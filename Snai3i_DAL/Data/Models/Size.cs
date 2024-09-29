using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_DAL.Data.Models
{
    public class Size : Deletebase, Isoftdelete
    {
        public int SizeId {  get; set; }

        public double Price { get; set; }

        public double ToolSize { get; set; }

        public int Stock {  get; set; }

        public ICollection<Tool> tools  { get; set; } = new HashSet<Tool>();    
    }
}
