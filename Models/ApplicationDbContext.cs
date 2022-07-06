using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace Blogger.Models
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public void AddChangeLog(ChangeType type, Blog blog, ClaimsPrincipal User, string description, string comment = "None")
        {
            ChangeLog log = new ChangeLog();

            log.ChangeLogType = type;

            log.BlogId = blog.BlogId;
            log.Description = description;
            log.Comment = comment;
            log.TimeStamp = DateTime.Now;
            //log.UserId = User?.Identity?.Name ?? "AnonymousUser";
            ChangeLogs.Add(log);


        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<ChangeLog> ChangeLogs { get; set; }
        public DbSet<Topic> Topics { get; set; }
    }
}
