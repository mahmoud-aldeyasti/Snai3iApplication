using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_BLL.DTO.ToolsDTO
{
    public class AddToolDTO
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public int ModifiedById { get; set; }

        public string ModifiedByName { get; set; }

        public DateTime ModifiedDateTime { get; set; }
        //  ICollection<Size> sizes { get; set; } = new HashSet<Size>();




    }
}
