using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_BLL.DTO.AcountDto
{
    public class ChangePasswordDto
    {
        public string Id { get; set; }

        [DataType(DataType.Password)]
        [Display ( Name = "current password ")]
        public string OldPassword {  get; set; }

        [DataType(DataType.Password)]
        [Display( Name = "new password ")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display ( Name = " confirm new password ")]
        [Compare( "NewPassword" , ErrorMessage ="confirm new password and new password " +
            "mush be matched ")]
        public string ConfirmNewPassword { get; set; }
    }
}
