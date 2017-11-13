using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseApplication.Models;
using BaseApplicationEntities.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BaseApplication.Controllers
{
    
    [Produces("application/json")]
    [Route("api/Account")]
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<User> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        public AccountModel Get()
        {
            return new AccountModel
            {
                Id = 1,
                FirstName = "Andrew",
                LastName = "khjhjh",
                Activated = true,
                Authorities = new []
                {
                    "ROLE_USER"
                },
                CreatedBy = "Me",
                CreatedDate = DateTime.Now,
                Email = "email@xxx.xx",
                ImageUrl = "http://nv.ua/img/section/30/0_tn.png",
                LangKey = "en",
                LastModifiedBy = "Me",
                LastModifiedDate = DateTime.Now
            };
        }

        [HttpPost("register")]
        public async Task<string> Register([FromBody]RegisterModel register)
        {
            if (await _userManager.FindByNameAsync(register.Login) != null)
                return "User Already Exists";

            var result = await _userManager.CreateAsync(new User { UserName = register.Login, Email = register.Email, EmailConfirmed = true, FirstName = "New User", LastName = "New User", LangKey = register.LangKey, Activated = "true", ImageUrl = "" }, register.Password);

            await _userManager.AddToRoleAsync(await _userManager.FindByNameAsync(register.Login), "ROLE_USER");

            return string.Empty;
        }
    }
}