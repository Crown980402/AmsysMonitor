using Microsoft.Win32;
using System.Reflection;
using AmsysMonitor.Models;

namespace AmsysMonitor.Services
{
    /// <summary>
    /// Windows 시작프로그램 등록 서비스
    /// </summary>
    public class StartupService
    {
        private const string RunKey =
            @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";

        private const string AppName =
            "AmsysMonitor";

        /// <summary>
        /// 설정 적용
        /// </summary>
        public void Apply(MonitorSetting setting)
        {
            if (setting.RunWithWindows)
            {
                Enable();
            }
            else
            {
                Disable();
            }
        }

        /// <summary>
        /// 시작프로그램 등록
        /// </summary>
        public void Enable()
        {
            using (RegistryKey key =
                Registry.CurrentUser.OpenSubKey(RunKey, true))
            {
                key?.SetValue(
                    AppName,
                    $"\"{Assembly.GetExecutingAssembly().Location}\"");
            }
        }

        /// <summary>
        /// 시작프로그램 해제
        /// </summary>
        public void Disable()
        {
            using (RegistryKey key =
                Registry.CurrentUser.OpenSubKey(RunKey, true))
            {
                if (key?.GetValue(AppName) != null)
                {
                    key.DeleteValue(AppName);
                }
            }
        }

        /// <summary>
        /// 등록 여부 확인
        /// </summary>
        public bool IsEnabled()
        {
            using (RegistryKey key =
                Registry.CurrentUser.OpenSubKey(RunKey))
            {
                return key?.GetValue(AppName) != null;
            }
        }
    }
}