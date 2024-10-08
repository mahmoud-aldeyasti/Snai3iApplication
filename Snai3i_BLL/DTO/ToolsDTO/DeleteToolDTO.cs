using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_BLL.DTO.ToolsDTO
{
    public class DeleteToolDTO
    {

        public int Id { get; set; }
        public int DeletedById { get; set; }
        public string DeletedByName { get; set; }
        public DateTime DeletedDateTime { get; set; }



    }
}
