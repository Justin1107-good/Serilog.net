# Serilog.net
Serilog.net 简单日志

# serilog官方
   [Github](https://github.com/serilog/serilog) 
   ![image](https://github.com/Justin1107-good/Serilog.net/blob/cb7bcab196966b6e70f26917492492c84778b17d/11.png)
 Serilog.net 应用程序的诊断日志记录库。它易于设置，具有干净的 API，并且可以在所有最新的 .NET 平台上运行。虽然 Serilog 即使在最简单的应用程序中也很有用，但在检测复杂、分布式和异步应用程序和系统时，它对结构化日志记录的支持却大放异彩。
 
 # 开始
 ### 新建.Net 6的项目
 ![image](https://github.com/Justin1107-good/Serilog.net/blob/5bb21cba9dd230a7ca9ee3a231c1bcddb9da0c82/Project%20structure%20diagram.png)
 
 ### Serilog NuGet 安装
 [Serilog NuGet](https://www.nuget.org/packages?q=Serilog)
 ```
 Install-Package Serilog -Version 2.12.0
 Install-Package Serilog.Sinks.Console -Version 4.1.1-dev-00896
 Install-Package Serilog.Sinks.File -Version 5.0.1-dev-00947
 ```
 ### 设置 Serilog 的最简单方法是使用静态类SerilogConsole。
 ```
  /// <summary>
    /// Serilog .NET 应用程序的诊断日志记录配置库
    /// </summary>
    public class SerilogConsole
    {
        /// <summary>
        /// 日志写入类
        /// </summary>
        /// <param name="context">内容</param>
        public static void WriteLog(string context)
        {
            Log.Logger = new LoggerConfiguration()
             .MinimumLevel.Information()
             .WriteTo.Console() 
             .WriteTo.File("log.txt",
                 rollingInterval: RollingInterval.Day,
                 rollOnFileSizeLimit: true)
             .CreateLogger();
            Log.Information(context);
            Log.CloseAndFlush();
        }

    }
 ```
 
 ### Program 添加如下代码
 ```
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
 ```
    
 ### 运行结果展示
 
   ![image](https://github.com/Justin1107-good/Serilog.net/blob/20d70547c39770b4648e31870d1f4c4bb08418f4/src/Web.Serilog.net/Web.Serilog.net/images/result.png)

 ### 结束  
                                                      孤独并不可怕，每个人都是孤独的，可怕的是害怕孤独！
