using Snai3i_DAL.Data.service.ErrorHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Snai3i_DAL.Data.service.ExceptionMiddleware
{
    public class ExceptionApiResponse : ApiResponse
    {
        public string? _details {  get; set; }



        public ExceptionApiResponse(int statuscode , string? message , string? details  ) : 
            base( statuscode , message )  
        {
            _details = details;
        }

    }
}
