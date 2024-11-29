using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_DAL.Data.service.ErrorHandling
{
    public class ValidationErrorApiResponse : ApiResponse
    {
        public IEnumerable<string> Errors { get; set; }

        public ValidationErrorApiResponse(  ) : base( (int) HttpStatusCode.BadRequest )
        {
            Errors = new List<string>();
        }
    }
}
