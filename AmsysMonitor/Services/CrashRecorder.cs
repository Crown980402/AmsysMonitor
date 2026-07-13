using System;
using System.Diagnostics;
using AmsysMonitor.Utils;

namespace AmsysMonitor.Services
{
    public class CrashRecorder
    {
        public void Record(Process process, string reason)
        {
            try
            {
                Logger.Error("========================================");
                Logger.Error("Crash Detected");

                Logger.Error($"Time : {DateTime.Now}");

                Logger.Error($"Reason : {reason}");

                Logger.Error($"Process : {process.ProcessName}");

                Logger.Error($"PID : {process.Id}");

                Logger.Error($"Responding : {process.Responding}");

                Logger.Error($"Memory : {process.WorkingSet64 / 1024 / 1024} MB");

                Logger.Error("========================================");
            }
            catch (Exception ex)
            {
                Logger.Error($"CrashRecorder 오류 : {ex.Message}");
            }
        }
    }
}