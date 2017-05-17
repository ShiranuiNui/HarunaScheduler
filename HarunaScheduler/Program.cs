using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace HarunaScheduler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            using (var db = new Models.SchedulerContext())
            {
                db.Schedules.Add(new Models.Schedule { Title = "TESTSCHEDULE", StartTime = DateTime.Now, StopTime = DateTime.Now });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All blogs in database:");
                foreach (var blog in db.Schedules)
                {
                    Console.WriteLine(" - {0}",blog.Title);
                }
            }
            */
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseDefaultServiceProvider(options =>
                    options.ValidateScopes = false)
                .UseUrls("http://*:50120/")
                .Build();
    }
}
