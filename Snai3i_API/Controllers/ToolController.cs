﻿using Microsoft.AspNetCore.Http;
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
        public async Task<IActionResult> GetTool(/*int pagesize , int pageindex*/ )
        {
            try
            {
                return Ok(await _toolManager.GetAllAsync());
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }
        }



        //get by id 

        [HttpGet]
        [Route("{Id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            try
            {
                return Ok(await _toolManager.GetByIdAsync(Id));
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }
        }


        //Add tool

        [HttpPost]
        public async Task<IActionResult> AddTool([FromForm] AddToolDTO toolAddDTO)
        {
            try
            {
                var adminName = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

                //if (adminName == null)
                //{
                //    return Unauthorized("User not authenticated");
                //}

                await _toolManager.AddAsync(toolAddDTO);
                return Ok("Tool Added Successfully");
            }
            catch (Exception ex)
            {

                return Content($" unfortunately your review is not added + {ex.InnerException.Message}");
            }
        }



        //update tool 

        [HttpPut]
        [Route("{Id}")]
        public async Task<ActionResult> EditTool(int Id, [FromForm] UpdateToolDTO toolUpdateDTO)
        {
            var adminName = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            try
            {
            //    if (adminName == null)
            //{
            //    return Unauthorized("User not authenticated");
            //}

            if (Id != toolUpdateDTO.Id)
            {
                return BadRequest();
            }

            await _toolManager.UpdateAsync(toolUpdateDTO);
            return NoContent();

            }
            catch (Exception ex)
            {
                return Content($"cant alter your review as + {ex.InnerException.Message}");
            }

        }



        //delete tool

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> DeleteTool(int id)
        {
            var adminName = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            try
            {
            //    if (adminName == null)
            //{
            //    return Unauthorized("User not authenticated");
            //}

                await _toolManager.DeleteAsync(id);
                return Content("your Tool is deleted successfuly!");

            } catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }

        }

      
               

    }
            
}


  
