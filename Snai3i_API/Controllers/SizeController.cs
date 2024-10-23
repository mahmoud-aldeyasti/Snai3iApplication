﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Snai3i_BLL.DTO.SizesDTO;
using Snai3i_BLL.DTO.ToolsDTO;
using Snai3i_BLL.Manager.SizesManager;
using System.Security.Claims;

namespace Snai3i_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SizeController : ControllerBase
    {
        private readonly ISizeManager _sizeManager;

        public SizeController(ISizeManager sizeManager)
        {
            _sizeManager = sizeManager;
        }


        [HttpPost]
        public async Task<IActionResult> AddSize([FromBody] AddSizeDTO AddDTO)
        {


            await _sizeManager.AddAsync(AddDTO);
            return NoContent();
        }


        //update tool 

        [HttpPut]
        [Route("{Id}")]
        public async Task<ActionResult> Edit(int Id, UpdateSizeDTO update)
        {
            var adminName = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;



            if (Id != update.Id)
            {
                return BadRequest();
            }

            await _sizeManager.UpdateAsync(update);
            return NoContent();



        }


        //delete tool

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> Delete(int id)
        {

            await _sizeManager.DeleteAsync(id);
            return Content("your size is deleted successfuly!");


        }


    }
}
