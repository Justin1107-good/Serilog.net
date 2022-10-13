using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Serilog.net.SerilogNet;

namespace Web.Serilog.net
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Hello, My first Serilog!
            SerilogConsole.WriteLog("Hello, My first Serilog!");
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
