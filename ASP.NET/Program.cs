using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Net;
using System.IO;
namespace ASP.NET
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebRequest req=WebRequest.Create("http://www.microsoft.com");
            WebResponse resp=req.GetResponse();
            StreamReader reader = new StreamReader(resp.GetResponseStream(),Encoding.ASCII);
            Console.WriteLine(reader.ReadToEnd());
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
