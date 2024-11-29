using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_DAL.Data.service.ErrorHandling
{
    public class ApiResponse
    {
        public int _statuscode {  get; set; }

        public string? _message { get; set; }

        public ApiResponse(int statuscode , string? message = null)
        {
            _statuscode = statuscode;
            _message = message ?? GetmessagefromstatusCode(_statuscode)  ;
        }


        private string? GetmessagefromstatusCode(int statuscode)
        {
            return statuscode switch { 
            400 => "Bad request be carefull ",
            401 => "Unauthorized",
            404 => "Resources were not found ",
            500 => "internal server Error",
            _ => null,
            
            };


        }
    }
}
