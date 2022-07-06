using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blogger
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
// Functionality created:
//      Sqlite connection created
//      Migrations created
//      Tables in ApplicationDbContext added
//      Blog, ChangeLog, Topic Models created
//      Added Models to the Migration
//      Controllers for each model added
//      Hide BlogId from non-authenticated users func. 
//      Added helper function to check TopicId in Topics Controller
//      Updated Layout in Shared Views to add Menu items
//      Redirected Index() in the Home Controller
//      Added Topic Name to the Index View in Blogs
//      Only Authenticated Users can Create new Blogs added
//      Displaying TopicId and Blog Id in respective views
//      Topics Details View: displaying Associated Blogs
//      Starting Users...