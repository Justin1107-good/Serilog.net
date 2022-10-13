using Serilog;

namespace Web.Serilog.net.SerilogNet
{
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
}
