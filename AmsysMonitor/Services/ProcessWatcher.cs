using System;
using System.Diagnostics;
using AmsysMonitor.Models;
using AmsysMonitor.Utils;

namespace AmsysMonitor.Services
{
    public class ProcessWatcher
    {
        private readonly MonitorSetting setting;

        public ProcessWatcher(MonitorSetting setting)
        {
            this.setting = setting;
        }

        /// <summary>
        /// Amsys가 실행 중인지 확인
        /// </summary>
        public bool IsMainRunning()
        {
            try
            {
                return Process.GetProcessesByName("Amsys").Length > 0;
            }
            catch (Exception ex)
            {
                Logger.Error(ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// Amsys2Kocom이 실행 중인지 확인
        /// </summary>
        public bool IsKocomRunning()
        {
            try
            {
                return Process.GetProcessesByName(setting.ProcessName).Length > 0;
            }
            catch (Exception ex)
            {
                Logger.Error(ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// 프로세스 객체 반환
        /// </summary>
        public Process GetKocomProcess()
        {
            try
            {
                Process[] processes =
                    Process.GetProcessesByName(setting.ProcessName);

                if (processes.Length == 0)
                    return null;

                return processes[0];
            }
            catch (Exception ex)
            {
                Logger.Error(ex.ToString());
                return null;
            }
        }
    }
}