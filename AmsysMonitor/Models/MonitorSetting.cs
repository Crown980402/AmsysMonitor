using AmsysMonitor.Utils;

namespace AmsysMonitor.Models
{
    /// <summary>
    /// 프로그램 전체 설정
    /// </summary>
    public class MonitorSetting
    {
        public string ProcessName { get; set; } = "Amsys2Kocom";

        public string ProgramPath { get; set; }
            = @"C:\Omnisystem\Amsys21\Amsys2Kocom.exe";

        public int CheckInterval { get; set; } = 5000;

        public int RestartDelay { get; set; } = 30;

        public bool AutoStartMonitor { get; set; } = true;

        public bool RunWithWindows { get; set; } = false;

        public bool StartMinimized { get; set; } = true;

        public bool EnableLog { get; set; } = true;

        public int MaxRestartCount { get; set; } = 0;

        public MonitorSetting()
        {
            Load();
        }

        public void Load()
        {
            IniFile ini = new IniFile("config.ini");

            ProcessName =
                ReadString(ini, "ProcessName", ProcessName);

            ProgramPath =
                ReadString(ini, "ProgramPath", ProgramPath);

            CheckInterval =
                ReadInt(ini, "CheckInterval", CheckInterval);

            RestartDelay =
                ReadInt(ini, "RestartDelay", RestartDelay);

            AutoStartMonitor =
                ReadBool(ini, "AutoStartMonitor", AutoStartMonitor);

            RunWithWindows =
                ReadBool(ini, "RunWithWindows", RunWithWindows);

            StartMinimized =
                ReadBool(ini, "StartMinimized", StartMinimized);

            EnableLog =
                ReadBool(ini, "EnableLog", EnableLog);

            MaxRestartCount =
                ReadInt(ini, "MaxRestartCount", MaxRestartCount);
        }

        private string ReadString(
            IniFile ini,
            string key,
            string defaultValue)
        {
            string value = ini.Read(key);

            return string.IsNullOrWhiteSpace(value)
                ? defaultValue
                : value;
        }

        private int ReadInt(
            IniFile ini,
            string key,
            int defaultValue)
        {
            return int.TryParse(
                ini.Read(key),
                out int value)
                ? value
                : defaultValue;
        }

        private bool ReadBool(
            IniFile ini,
            string key,
            bool defaultValue)
        {
            return bool.TryParse(
                ini.Read(key),
                out bool value)
                ? value
                : defaultValue;
        }
    }
}