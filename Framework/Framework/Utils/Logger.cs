using Serilog;
using System.IO;


namespace Framework.Utils
{
    class Logger
    {
        private static string _pathDirectoryLogs = "../../../Logs";
        private static string _pathFileLogs = "../../../Logs/TestsLog.log";

        static Logger()
        {
            if (Directory.Exists(_pathDirectoryLogs))
            {
                Directory.CreateDirectory(_pathDirectoryLogs);
            }
                
            if (File.Exists(_pathFileLogs))
            {
                File.Delete(_pathFileLogs);
            }

            Log.Logger = new LoggerConfiguration().MinimumLevel.Information().WriteTo.File(_pathFileLogs, outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
                .CreateLogger();
        }

        public static void ShowInfo(string information)
        {
            Log.Information(information);
        }
    }
}
