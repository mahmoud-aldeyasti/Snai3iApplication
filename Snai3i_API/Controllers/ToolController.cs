using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Snai3i_BLL.DTO.ToolsDTO;
using Snai3i_BLL.Manager.ToolsManager;
using System.Security.Claims;

namespace Snai3i_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToolController : ControllerBase
    {

        private readonly IToolManager _toolManager;
        public ToolController(IToolManager toolManager)
        {
            _toolManager = toolManager;
        }

        //Get All

        [HttpGet]
        public async Task<IActionResult> GetTool()
        {
            return Ok(await _toolManager.GetAllAsync());
        }

        //get by id 

        [HttpGet]
        [Route("{Id}")]
        public async Task<IActionResult> GetById(int Id)
        {

            return Ok(await _toolManager.GetByIdAsync(Id));

        }

        //Add tool

        [HttpPost]
        public async Task<IActionResult> AddTool([FromBody]AddToolDTO toolAddDTO)
        {
            var adminName = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (adminName == null)
            {
                return Unauthorized("User not authenticated");
            }
           
            await _toolManager.AddAsync(toolAddDTO);
            return NoContent();

        }

        //update tool 

        [HttpPut]
        [Route("{Id}")]
        public async Task<ActionResult> EditTool(int Id, [FromBody] UpdateToolDTO toolUpdateDTO)
        {
            var adminName = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (adminName == null)
            {
                return Unauthorized("User not authenticated");
            }

            if (Id != toolUpdateDTO.Id)
            {
                return BadRequest();
            }

            await _toolManager.UpdateAsync(toolUpdateDTO);
            return NoContent();

        }



        //delete tool

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> DeleteTool(int id)
        {
            var adminName = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (adminName == null)
            {
                return Unauthorized("User not authenticated");
            }

            await _toolManager.DeleteAsync(id);
            return NoContent();

        }


    }
}
