﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_BLL.DTO.AcountDto
{
    public class LoginDTO
    {
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
