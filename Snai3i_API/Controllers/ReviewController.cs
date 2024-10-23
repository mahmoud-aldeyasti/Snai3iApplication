using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Snai3i_BLL.DTO.ReviewDto;
using Snai3i_BLL.Manager.ReviewsManager;

namespace Snai3i_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewManager _reviewManager;

        public ReviewController(IReviewManager reviewManager )
        {
            _reviewManager = reviewManager;
        }
        [HttpPost]
        public async Task<IActionResult> AddReview(ReviewAddDTO reviewAddDTO)
        {
            await _reviewManager.AddReviewAsync(reviewAddDTO);
            return Ok("Review Added Successfully");
        }


        [HttpGet]
        [Route("{workerId}")]
        public async Task<IActionResult> GetReviewsForWorker(string workerId)
        {

             var reviews = await _reviewManager.GetReviewsForWorkerAsync(workerId);
            if (reviews == null) { 
                return NotFound();
            }   
                
             return Ok(reviews);

        }
        [HttpGet]
        [Route("{Id:int}")]
        public async Task<IActionResult> GetById(int Id)
        {
            var review = await _reviewManager.GetByIdAsync(Id);
            if (review == null)
            {
                return NotFound("Key Not Found");
            }
            return Ok(review);
        }

        [HttpPut]
        [Route("{Id}")]
        public async Task<IActionResult> Edit(int Id, ReviewUpdateDTO reviewUpdateDTO)
        {
                if (Id != reviewUpdateDTO.Id)
                {
                    return BadRequest();
                }

                await _reviewManager.UpdateAsync(reviewUpdateDTO);
                return NoContent();
        }

        [HttpDelete]
        [Route("{Id}")]
        public async Task<IActionResult> DeleteReview(int Id)
        {

                var review = await _reviewManager.GetByIdAsync(Id);
                if (review == null)
                {
                    return NotFound("Review not found");
                }

                await _reviewManager.DeleteAsync(Id);
                return Content("Your review is deleted successfully!");


        }
    }
}
