using System;
using System.Collections.Generic;
using System.Linq;
using BaseApplicationEntities.Domain;
using Microsoft.AspNetCore.Identity;

namespace BaseApplicationEntities
{
    public class DBInitializer : IDBInitializer
    {
        private readonly BaseAppContext _context;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DBInitializer(BaseAppContext context,
            UserManager<User> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async void Seed()
        {
            _context.Database.EnsureCreated();

            if(_context.Roles.Any())
            {
                return;
            }

            await _roleManager.CreateAsync(new IdentityRole("ROLE_ADMIN"));
            await _roleManager.CreateAsync(new IdentityRole("ROLE_USER"));

            string user = "admin";
            string email = "admin@admin.adm";
            string password = "Qadmin1__";
            var result = await _userManager.CreateAsync(new User { UserName = user, Email = email, EmailConfirmed = true, FirstName = "Admin", LastName = "Admin", LangKey="en", Activated = "true", ImageUrl = ""  }, password);
            await _userManager.AddToRoleAsync(await _userManager.FindByNameAsync(user), "ROLE_ADMIN");

            user = "user";
            email = "user@admin.adm";
            password = "Qpassword1__";
            await _userManager.CreateAsync(new User { UserName = user, Email = email, EmailConfirmed = true, FirstName = "Admin", LastName = "Admin", LangKey = "en", Activated = "true", ImageUrl = "" }, password);
            await _userManager.AddToRoleAsync(await _userManager.FindByNameAsync(user), "ROLE_USER");
        }
    }
}
