using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Snai3i_BLL.DTO.AcountDto;
using Snai3i_DAL.Data.Models;
using Snai3i_DAL.Data.Repository.service;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_BLL.Manager.Acountmanager
{
    public class AccountManager : IAccountManager
    {
        private readonly UserManager<ApplicationUser> _userManager;

        private readonly IConfiguration _configuration;

        private readonly Ifileservice _fileservice;

        public AccountManager( UserManager<ApplicationUser> userManager , IConfiguration configuration, Ifileservice fileservice)
        { 
            _configuration = configuration;
            _userManager = userManager;
            _fileservice = fileservice;

        }



        public async Task<GeneralResponse> login(loginDTO log)
        {
            var usermanager =  await _userManager.FindByEmailAsync(log.email);

            if (usermanager == null) {
                return null; 
            }
            var result =  await _userManager.CheckPasswordAsync( usermanager , log.password );
            if (result == false) {
                return null; 

            }
            var claims = await _userManager.GetClaimsAsync(usermanager);
            return GenerateToken(claims); 
        }

        public async Task<GeneralResponse> RegisterUser([FromForm] UserRegisterDto userRegisterDto)
        {
            
            var user = new User() ;
            user.UserName = userRegisterDto.first_name;
            user.LastName = userRegisterDto.last_name;
            var imageresult = _fileservice.SaveImage(userRegisterDto.imageFile);
            if (imageresult.Item1 == 1) { 
                user.image = imageresult.Item2;
            }
            else
            {
                user.image = "failure.png"; 
            }
            user.Email = userRegisterDto.email;
            IdentityResult result = await _userManager.CreateAsync(user , userRegisterDto.password );

            if (result.Succeeded == false) {
                return null;
            }
                List<Claim> claims = new List<Claim>() ;
                claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Id));
                claims.Add(new Claim("first_name", userRegisterDto.first_name) ) ;
                claims.Add(new Claim(ClaimTypes.Role, usertype.User.ToString() )); 
                //claims.Add(new Claim(ClaimTypes.Role, (string)usertype.User));
                await _userManager.AddClaimsAsync(user , claims ); 
            return GenerateToken( claims ); 

        }

        public async Task<GeneralResponse> RegisterWorker([FromForm] WorkerRegisterDto WorkerRegisterDto)
        {
            var worker = new Worker();
            worker.Nationalnumber = WorkerRegisterDto.Nationalnumber;
            worker.UserName = WorkerRegisterDto.first_name;
            worker.LastName = WorkerRegisterDto.last_name;
            worker.Email = WorkerRegisterDto.email;
            string passedpassword = WorkerRegisterDto.password;
            var imageresult = _fileservice.SaveImage(WorkerRegisterDto.imageFile);
            if (imageresult.Item1 == 1)
            {
                worker.image = imageresult.Item2;
            }
            else
            {
                worker.image = "failure.png";
            }
            IdentityResult result = await _userManager.CreateAsync(worker, passedpassword);

            if (result.Succeeded == false)
            {
                
                return null;
            }
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.NameIdentifier, worker.Id));
            claims.Add(new Claim("first_name", WorkerRegisterDto.first_name));
            claims.Add(new Claim(ClaimTypes.Role, usertype.Worker.ToString() )); 
            await _userManager.AddClaimsAsync(worker, claims);
            return GenerateToken(claims);
        }

        private GeneralResponse GenerateToken( IList<Claim> claims)
        {
            var secretKeyString = _configuration.GetValue<string>("SK"); 
            var secretKeyBytes = Encoding.ASCII.GetBytes(secretKeyString);  
            SecurityKey securityKey = new SymmetricSecurityKey ( secretKeyBytes);


            SigningCredentials signingcredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var _expiredate = DateTime.Now.AddDays(1); 
            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(
                claims: claims,
                signingCredentials: signingcredentials,
                expires: _expiredate
                );
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();

            string _token = tokenHandler.WriteToken(jwtSecurityToken);   

            return new GeneralResponse()
            {
                token = _token,  
                expiredate = _expiredate
            };  
        }
    }
}
