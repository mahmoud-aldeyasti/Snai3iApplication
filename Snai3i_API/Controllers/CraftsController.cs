using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Snai3i_BLL.DTOS.CraftDto;
using Snai3i_BLL.Manager.CraftsManager;

namespace Snai3i_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CraftsController : ControllerBase
    {
        private readonly ICraftManger _craftManger;

        public CraftsController(ICraftManger craftManger)
        {
            _craftManger = craftManger;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _craftManger.GetAllCraftAsync());
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _craftManger.GetCraftByIdAsync(id));
        }
        [HttpPost]
        public async Task<IActionResult> Add(CraftAddDTO craftAddDTO)
        {
            await _craftManger.AddCraftAsync(craftAddDTO);
            return NoContent();
        }
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update(int id, CraftUdateDTO craftUdateDTO)
        {
            if (id != craftUdateDTO.CraftId)
            {
                return BadRequest();
            }
            
            await _craftManger.EidetCraftAsync(craftUdateDTO);
            return NoContent();
        }
        [HttpDelete]
        [Route("{id}")]
        public  IActionResult Delete(int id)
        {

            _craftManger.DeleteCraftAsync(id);
            return NoContent();
        }
    }
}
