using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using Newtonsoft.Json;
using NuGet.Configuration;
using Snai3i_BLL.DTO.AcountDto;
using Snai3i_BLL.DTO.WorkerDto;
using Snai3i_DAL.Data.Models;
using Snai3i_MVC.Models;

using System.Diagnostics;
using System.Drawing.Printing;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Snai3i_MVC.Controllers
{
    [Route("Accounts")]
    public class AccountController : Controller
    {

        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;


        public AccountController(HttpClient httpClient,
            IConfiguration configuration)
        {
            _httpClient = httpClient;
            this._configuration = configuration;

            _httpClient.BaseAddress = new Uri("https://localhost:7000/");
        }
        [HttpGet("Index")]
        public IActionResult Index()
        {
            return View("Index");
        }

        //Account/Login
        [HttpGet("Login")]
        public ActionResult Login()
        {
            return View("Login");
        }


        [HttpPost]
        [Route("LoginSave")]
        public async Task<ActionResult> LoginSave(LoginDTO login)
        {

            // Create the JSON content to send
            var loginData = new
            {
                email = login.email,
                password = login.password
            };

            // Convert the loginData object to JSON format
            var jsonContent = new StringContent(JsonSerializer.Serialize(loginData), Encoding.UTF8,
                "application/json");

            // Send POST request to API
            var httpResponse = await _httpClient.PostAsync("/api/Account/Login", jsonContent);

            if (httpResponse.IsSuccessStatusCode)
            {
                // Read the token from the response body (assuming API sends token in plain text or JSON)
                var responseBody = await httpResponse.Content.ReadAsStringAsync();
                var token = JsonSerializer.Deserialize<GeneralResponse>(responseBody)?.token; // Adjust based on your API response structure

                //Store the token in session
                HttpContext.Session.SetString("AuthToken", token);
                // decode the token to know the roles of the user 
                var roleclaim = GetRoles(token);
                // if the logged in user is admin or superadmin it goes to the dashboard 
                // if not admin or superadmin it goes to the logged user view  
                foreach(var role in roleclaim)
                {
                    if(role.Value == usertype.Admin.ToString() ||
                        role.Value == usertype.SuperAdmin.ToString() )
                    {
                        return View("Index");
                    }
                }
                return View( "Logged", login );

                // return RedirectToAction("GetallWorkers", "Worker");
                // Redirect to a relevant page after successful login

                

            }
            else
            {
                // Extract error message from the response and display it
                var error = await httpResponse.Content.ReadAsStringAsync();
                ViewBag.ErrorMessage = "Login failed: " + error;
                return View("Login"  );
            }
        }



        [HttpGet("Profile")]
        public async Task<IActionResult> Profile(string mail)
        {
            var token = HttpContext.Session.GetString("AuthToken");

            var url = $"/api/Account/GetByIdMailAsync?mail={mail}";

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                "Bearer", token); 

            var httpresponse = await _httpClient.GetAsync(url);

            if (httpresponse.IsSuccessStatusCode)
            {
                var content = await httpresponse.Content.ReadAsStringAsync();

                var settings = new JsonSerializerSettings
                {
                    MissingMemberHandling = MissingMemberHandling.Ignore,
                    NullValueHandling = NullValueHandling.Ignore
                };


                var appuser =  JsonConvert.DeserializeObject<ApplicationUserReadDto>(content
                    , settings);

                return View(appuser);
            }
            return View("Error", new ErrorViewModel { RequestId = 
                Activity.Current?.Id ?? HttpContext.TraceIdentifier });


        }

        [HttpGet("Register")]

        //Account/RegisterUser
        public ActionResult Register()
        {
            return View();
        }


        [HttpPost]
        [Route("Register")]
        public async Task<ActionResult> Register([FromForm] RegisterDto register)
        {
            if (ModelState.IsValid)
            {
                string url = "/api/Account/Register";

                using (var content = new MultipartFormDataContent())
                {
                    content.Add(new StringContent(register.first_name), "first_name");
                    content.Add(new StringContent(register.last_name), "last_name");
                    content.Add(new StringContent(register.email), "email");
                    content.Add(new StringContent(register.password), "password");
                    content.Add(new StringContent(register.ConfirmPassword), "ConfirmPassword");
                    content.Add(new StringContent(register.usertype.ToString()), "usertype");  // Send the user type

                    if (register.imageFile != null)
                    {
                        var fileContent = new StreamContent(register.imageFile.OpenReadStream());
                        fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(register.imageFile.ContentType);
                        content.Add(fileContent, "imageFile", register.imageFile.FileName);
                    }

                    var httpResponse = await _httpClient.PostAsync(url, content);

                    if (httpResponse.IsSuccessStatusCode)
                    {
                        var response = await httpResponse.Content.ReadAsStreamAsync();
                        var token = JsonSerializer.Deserialize<GeneralResponse>(response)?.token;
                        HttpContext.Session.SetString("AuthToken", token);
                        // decode the token to know the roles of registered user 
                        var roleclaim = GetRoles(token);

                        // loop the roles of registered user if it's admin or super admin 
                        // it goes to the dashboard if not admin or superadmin it goes to 
                        // the registeration view 
                        foreach (var role in roleclaim)
                        {
                            if (role.Value == usertype.Admin.ToString() ||
                                role.Value == usertype.SuperAdmin.ToString())
                            {
                                return View("Index");
                            }

                        }

                        return View("Registered" , register);
                    }
                    else
                    {
                        var error = await httpResponse.Content.ReadAsStringAsync();
                        ViewBag.ErrorMessage = "Registration failed: " + error;
                    }
                }
            }

            return View("Register");
        }
        [HttpGet("Signout")]
        public async Task<IActionResult> Signout()
        {
            var token = HttpContext.Session.GetString("AuthToken");


            var url = "/api/Account/SignOut";

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                "Bearer", token);

            var httpresponse = await _httpClient.GetAsync(url);



            if (httpresponse.IsSuccessStatusCode) {
                HttpContext.Session.Remove("AuthToken");
                return RedirectToAction("Login" , "Accounts");
            }

            var error = await httpresponse.Content.ReadAsStringAsync();
            ViewBag.ErrorMessage = "Singout failed: " + error;
            return View("Logged"); 
           
        }

        [HttpGet("Edit")]
        public async Task<IActionResult> Edit(string user_Id)
        {
            var token = HttpContext.Session.GetString("AuthToken");

            if (string.IsNullOrEmpty(token) ){
                return RedirectToAction("Login", "Accounts");
            }

            var url = $"https://localhost:7000/api/Account/{user_Id}";

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                "Bearer", token); 

            var httpResponse = await  _httpClient.GetAsync(url);

            if(httpResponse.IsSuccessStatusCode)
            {
                var Content = await httpResponse.Content.ReadAsStringAsync();
                var settings = new JsonSerializerSettings
                {
                    MissingMemberHandling = MissingMemberHandling.Ignore,
                    NullValueHandling = NullValueHandling.Ignore,
                };

                var appUserEdit = JsonConvert.DeserializeObject<ApplicationUserEditDto>(Content , settings);

                return View (appUserEdit);
               
            }
            var error = await httpResponse.Content.ReadAsStringAsync();
            ViewBag.ErrorMessage = "Registration failed: " + error;
            return RedirectToAction("Profile", "Accounts" );

        }

        [HttpPost("Edit")]
        [Route("{user_Id}")]

        public async Task<IActionResult> Edit(string user_Id , [FromForm] ApplicationUserEditDto appuserEdit)
        {
            if (ModelState.IsValid)
            {

                var token = HttpContext.Session.GetString("AuthToken");

                var url = $"/api/Account/Edit/{user_Id}";

                    using (var content = new MultipartFormDataContent())
                    {
                        content.Add(new StringContent(appuserEdit.FirstName), "FirstName");
                        content.Add(new StringContent(appuserEdit.LastName), "LastName");
                        content.Add(new StringContent(appuserEdit.Email), "Email");
                        content.Add(new StringContent(appuserEdit.phone), "phone");
                        content.Add(new StringContent(appuserEdit.userId), "userId");



                    if (appuserEdit.imageFile != null)
                        {
                            var fileContent = new StreamContent(appuserEdit.imageFile.OpenReadStream());
                            fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(appuserEdit.imageFile.ContentType);
                            content.Add(fileContent, "imageFile", appuserEdit.imageFile.FileName);
                        }


                        _httpClient.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer", token);

                        var httpresponse = await _httpClient.PutAsync(url, content);

                        if (httpresponse.IsSuccessStatusCode)
                        {
                            var result =await  httpresponse.Content.ReadAsStringAsync();
                            var settings = new JsonSerializerSettings
                            {
                                MissingMemberHandling = MissingMemberHandling.Ignore,
                                NullValueHandling = NullValueHandling.Ignore,
                            };

                            var appUser = JsonConvert.DeserializeObject<ApplicationUser>(result, settings);

                        return RedirectToAction("Profile", "Accounts" , new { mail = appUser.Email });
                        // be careful when redirection a route value in action redirect 
                        // pass it as parameter of anonymous object 


                        }
                        var Error = httpresponse.Content.ReadAsStringAsync();

                        ViewBag.ErrorMessage = "Edit failed: " + Error;

                        return View(Error);
                    }

                }
                return View(appuserEdit);
            
        }

        [HttpGet("ChangePassword/{ID}")]
        public async Task<IActionResult> ChangePassword(string ID)
        {
            var url = "api/Account/ChangePassword";

            var token = HttpContext.Session.GetString("AuthToken");

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                "Bearer", token);

            var httpresponse = await _httpClient.GetAsync(url);

            if (httpresponse.IsSuccessStatusCode) {
                return View(new ChangePasswordDto { Id = ID , } );
            }
            return RedirectToAction("Login", "Accounts");
        }

        [HttpPost("ChangePassword")]

        public async Task<IActionResult> ChangePassword(ChangePasswordDto changepassword)
        {
            var url = "api/Account/ChangePassword";

            var token = HttpContext.Session.GetString("AuthToken");

            var content = new StringContent(JsonSerializer.Serialize(changepassword),
                Encoding.UTF8, "application/json"); 


            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                "Bearer", token); 

            var httpresponse = await _httpClient.PostAsync(url, content);

            if (httpresponse.IsSuccessStatusCode) {
                var result = await httpresponse.Content.ReadAsStringAsync();
                var settings = new JsonSerializerSettings
                {
                    MissingMemberHandling = MissingMemberHandling.Ignore,
                    NullValueHandling = NullValueHandling.Ignore,
                };
                var loginuser = JsonConvert.DeserializeObject<LoginDTO>(result , settings);
                return View("ConfirmNewPassord" , loginuser); 
            }
            var errorstring =await httpresponse.Content.ReadAsStringAsync();
            ViewBag.ErrorMessage = "Changing Password failed : " + errorstring;
            return RedirectToAction("ChangePassword", "Accounts");

        }


        


        public List<Claim> GetRoles( string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var tokencoded = handler.ReadJwtToken(token);
            var roleclaim = tokencoded.Claims.Where(a => a.Type == ClaimTypes.Role).ToList();
            return roleclaim;
        }
    
    }
}
