using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Snai3i_DAL.Data.service.ErrorHandling;


namespace Snai3i_API.Controllers
{
    [Route("Errors/{code}")]
    [ApiExplorerSettings( IgnoreApi = true )]   
    [ApiController]
    public class ErrorsController : ControllerBase
    {
        public ActionResult Error(int code)
        {
            return NotFound(new ApiResponse(code));
        }
    }
}
