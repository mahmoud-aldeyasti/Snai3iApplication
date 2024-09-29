using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_DAL.Data.Models
{
    public enum usertype
    {
       SuperAdmin ,Admin , User , Worker 
    }
    public class ApplicationUser : Deletebase
    {

        public int Id { get; set; }

        public usertype Role { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public String  email { get; set; }  
        public  String  password { get; set; }
        public  int  phone { get; set; }
        public string  image {  get; set; }

    }
}
