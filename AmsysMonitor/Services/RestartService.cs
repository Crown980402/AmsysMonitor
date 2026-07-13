using System;
using System.Diagnostics;
using System.IO;
using AmsysMonitor.Models;
using AmsysMonitor.Utils;

namespace AmsysMonitor.Services
{
    public class RestartService
    {
        private readonly MonitorSetting setting;

        private DateTime lastRestart = DateTime.MinValue;

        public RestartService(MonitorSetting setting)
        {
            this.setting = setting;
        }

        public bool Restart()
        {
            if ((DateTime.Now - lastRestart).TotalSeconds <
                setting.RestartDelay)
            {
                return false;
            }

            if (!File.Exists(setting.ProgramPath))
            {
                Logger.Error("실행 파일이 존재하지 않습니다.");
                return false;
            }

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = setting.ProgramPath,
                    UseShellExecute = true,
                    Verb = "runas"
                });

                lastRestart = DateTime.Now;

                Logger.Info("Amsys2Kocom.exe 재실행 성공");

                return true;
            }
            catch (Exception ex)
            {
                Logger.Error(ex.ToString());

                return false;
            }
        }
    }
}