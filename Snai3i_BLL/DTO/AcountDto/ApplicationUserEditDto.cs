using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_BLL.DTO.AcountDto
{
    public class ApplicationUserEditDto
    {
        public string userId {  get; set; }
        


        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public IFormFile imageFile { get; set; }

        [DataType(DataType.EmailAddress , ErrorMessage = " Please Enter valid email address")]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber, ErrorMessage = "Please Enter valid phone number ")  ]
        public string phone { get; set; }

    }
}
