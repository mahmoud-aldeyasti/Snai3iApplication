using Snai3i_BLL.DTO.SizesDTO;
using Snai3i_DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_BLL.DTO.ToolsDTO
{
    public class ReadToolDTO
    {
        public string Name { get; set; }

        public string Description { get; set; }

        //public decimal Price { get; set; }

        public string Image { get; set; }

        //public int CreatedById { get; set; }

        //public string? CreatedByName { get; set; }

        //public DateTime CreatedDateTime { get; set; }
        public List<ReadSizeDTO> sizes { get; set; } 




    }
}
