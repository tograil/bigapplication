using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace BaseApplicationEntities.Domain
{
    public class User : IdentityUser
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Activated { get; set; }
        public string LangKey { get; set; }
        public string ImageUrl { get; set; }
        public string ActivationKey { get; set; }
    }
}
