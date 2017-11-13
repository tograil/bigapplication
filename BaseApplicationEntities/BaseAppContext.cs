using System;
using System.Collections.Generic;
using System.Text;
using BaseApplicationEntities.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BaseApplicationEntities
{
    public class BaseAppContext : IdentityDbContext<User>
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Authority> Authorities { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<ClaimRebuttal> ClaimRebuttals { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Crisis> Crisises { get; set; }
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Rebuttal> Rebuttals { get; set; }
        public DbSet<SocialUserConnection> SocialUsersConnections { get; set; }
        public DbSet<Talk> Talks { get; set; }

        public BaseAppContext(DbContextOptions options) : base(options)
        {
        }

        protected BaseAppContext() : base()
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
