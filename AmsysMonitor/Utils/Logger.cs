using System;
using System.IO;
using System.Linq;

namespace AmsysMonitor.Utils
{
    public static class Logger
    {
        private static readonly object _lock = new object();

        private static readonly string logDirectory =
            Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Logs");

        private const int KeepDays = 30;

        public static void Info(string message)
        {
            Write("INFO ", message);
        }

        public static void Warning(string message)
        {
            Write("WARN ", message);
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
                    if (!Directory.Exists(logDirectory))
                    {
                        Directory.CreateDirectory(logDirectory);
                    }

                    DeleteOldLogs();

                    string logFile =
                        Path.Combine(
                            logDirectory,
                            $"MonitorLog_{DateTime.Now:yyyyMMdd}.txt");

                    WriteHeaderIfNeeded(logFile);

                    string log =
                        $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{level}] {message}";

                    File.AppendAllText(
                        logFile,
                        log + Environment.NewLine);
                }
                catch
                {
                    // Logger 오류는 프로그램 동작에 영향을 주지 않음
                }
            }
        }

        /// <summary>
        /// 하루 첫 로그에 헤더 출력
        /// </summary>
        private static void WriteHeaderIfNeeded(string logFile)
        {
            if (File.Exists(logFile))
                return;

            File.AppendAllText(
                logFile,
$@"============================================================
Amsys Monitor Log

Date : {DateTime.Now:yyyy-MM-dd}

============================================================

");
        }

        /// <summary>
        /// 오래된 로그 자동 삭제
        /// </summary>
        private static void DeleteOldLogs()
        {
            try
            {
                var files =
                    Directory.GetFiles(
                        logDirectory,
                        "MonitorLog_*.txt");

                foreach (string file in files)
                {
                    FileInfo info = new FileInfo(file);

                    if (info.CreationTime <
                        DateTime.Now.AddDays(-KeepDays))
                    {
                        info.Delete();
                    }
                }
            }
            catch
            {
                // 삭제 실패는 무시
            }
        }
    }
}