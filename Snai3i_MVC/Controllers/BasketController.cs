using Microsoft.AspNetCore.Mvc;
using Snai3i_BLL.DTO;
using Snai3i_BLL.DTO.CraftDto;
using Snai3i_DAL.Data.Models;
using Snai3i_MVC.Models;
using System.Diagnostics;
using System.Text.Json;

namespace Snai3i_MVC.Controllers
{
    [Route("Basket")]
    public class BasketController : Controller
    {
        private readonly HttpClient _httpClient;

        public BasketController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
         
        // جلب السلة من API باستخدام HttpClient
        [HttpGet("GetBasket/{id}")]
        public async Task<IActionResult> GetBasket(string id)
        {
            string apiUrl = $"https://localhost:7000/api/Basket/{id}"; // URL الخاص بمشروع الـ API

            // إرسال طلب HTTP GET إلى الـ API
            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

            
                // قراءة استجابة الـ API وتحويلها إلى CustomerBasket
                var basketContent = await response.Content.ReadAsStringAsync();
                var basket = JsonSerializer.Deserialize<CustomerBasketDto>(basketContent);

                // عرض السلة في View
                return View("BasketView", basket);
            
            
        }
    }
}

    

