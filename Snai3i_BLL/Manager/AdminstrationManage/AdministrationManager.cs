using AutoMapper;
using Azure.Core;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Snai3i_BLL.DTO.AdminstrationDto;
using Snai3i_DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_BLL.Manager.AdminstrationManage
{
    public class AdministrationManager : IAdministrationManager
    {
        private readonly RoleManager<IdentityRole> roleManager;

        private readonly IMapper mapper;
        private readonly UserManager<ApplicationUser> userManager;

        public AdministrationManager(RoleManager<IdentityRole> roleManager
            , IMapper mapper , UserManager<ApplicationUser> userManager)
        {
            this.roleManager = roleManager;
            this.mapper = mapper;
            this.userManager = userManager;
        }
        
        public async Task<IdentityResult> CreateNewRoleAsync(AddRoleDto addRoleDto)
        {
            bool chechexist = await roleManager.RoleExistsAsync(addRoleDto?.RoleName);

            if (chechexist)
            {

                return IdentityResult.Failed(new IdentityError
                {
                    Description = "Role already exists"
                }); 
            }

            IdentityRole role = new IdentityRole()
            {
                Name = addRoleDto?.RoleName,
            };

            IdentityResult result =await roleManager.CreateAsync(role);

            return result; 
            

        }



        public async Task<List<RoleReadDto>> ListRolesAsync()
        {
           return  mapper.Map<List<IdentityRole> , List<RoleReadDto>>(await roleManager.Roles.ToListAsync() ); 
        }

        public async Task<EditRoleDto?> FindbyIDAsync(string RoleId)
        {
            return mapper.Map<IdentityRole?,EditRoleDto?> (await roleManager.FindByIdAsync(RoleId) );

        }

        public async Task<IdentityResult> Edit( EditRoleDto editRoleDto)
        {

                bool checkExist = await roleManager.RoleExistsAsync(editRoleDto?.Name);
            if (checkExist) {
                return IdentityResult.Failed(new IdentityError
                {
                    Description = "Role already exists"
                });
            }
                var role = await roleManager.FindByIdAsync(editRoleDto.Id); 
                role.Name = editRoleDto?.Name;

            return await roleManager.UpdateAsync(role);
            
        }

        public async Task<IdentityResult> AssignRoleToUser(string userId, string roleId)
        {
            var user = await userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return IdentityResult.Failed(new IdentityError { Description = "User not found" });
            }

            var role = await roleManager.FindByIdAsync(roleId);
            if (role == null)
            {
                return IdentityResult.Failed(new IdentityError { Description = "Role not found" });
            }

            var userRoles = await userManager.GetRolesAsync(user);
            if (userRoles.Contains(role.Name))
            {
                return IdentityResult.Failed(new IdentityError { Description = "User is already assigned to this role" });
            }

            var roleResult = await userManager.AddToRoleAsync(user, role.Name);
            if (!roleResult.Succeeded)
            {
                return roleResult;
            }

            var claimResult = await userManager.AddClaimAsync(user, new Claim(ClaimTypes.Role, role.Name));
            if (!claimResult.Succeeded)
            {
                return claimResult;
            }

            return IdentityResult.Success;
        }


        public async Task<IdentityResult> RemoveRoleFromUser(string userId, string roleId)
        {
            var user = await userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return IdentityResult.Failed(new IdentityError { Description = "User not found" });
            }

            var role = await roleManager.FindByIdAsync(roleId);
            if (role == null)
            {
                return IdentityResult.Failed(new IdentityError { Description = "Role not found" });
            }

            var userRoles = await userManager.GetRolesAsync(user);
            if (!userRoles.Contains(role.Name))
            {
                return IdentityResult.Failed(new IdentityError { Description = "User is not assigned to this role" });
            }

            var roleResult = await userManager.RemoveFromRoleAsync(user, role.Name);
            if (!roleResult.Succeeded)
            {
                return roleResult;
            }

            var claimResult = await userManager.RemoveClaimAsync(user, new Claim(ClaimTypes.Role, role.Name));
            if (!claimResult.Succeeded)
            {
                return claimResult;
            }

            return IdentityResult.Success;
        }

    }
}
