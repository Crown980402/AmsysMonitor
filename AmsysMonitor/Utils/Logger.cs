using System;
using System.IO;

namespace AmsysMonitor.Utils
{
    public static class Logger
    {
        private static readonly object _lock = new object();

        private static readonly string logFile =
            Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "MonitorLog.txt");

        public static void Info(string message)
        {
            Write("INFO", message);
        }

        public static void Warning(string message)
        {
            Write("WARN", message);
        }

        public static void Error(string message)
        {
            Write("ERROR", message);
        }

        private static void Write(string level, string message)
        {
            lock (_lock)
            {
                try
                {
                    File.AppendAllText(
                        logFile,
                        $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{level}] {message}{Environment.NewLine}");
                }
                catch
                {
                    // 로그 기록 실패는 무시
                }
            }
        }
    }
}