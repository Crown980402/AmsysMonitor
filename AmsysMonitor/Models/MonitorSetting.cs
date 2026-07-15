using AmsysMonitor.Utils;

namespace AmsysMonitor.Models
{
    /// <summary>
    /// 프로그램 전체 설정
    /// </summary>
    public class MonitorSetting
    {
        /// <summary>
        /// 감시할 프로세스 이름
        /// </summary>
        public string ProcessName { get; set; } = "Amsys2Kocom";

        /// <summary>
        /// 프로그램 실행 경로
        /// </summary>
        public string ProgramPath { get; set; }
            = @"C:\Omnisystem\Amsys21\Amsys2Kocom.exe";

        /// <summary>
        /// 감시 주기(ms)
        /// </summary>
        public int CheckInterval { get; set; } = 5000;

        /// <summary>
        /// 응답없음 판정 시간(초)
        /// </summary>
        public int HangTimeout { get; set; } = 10;

        /// <summary>
        /// 재시작 대기시간(초)
        /// </summary>
        public int RestartDelay { get; set; } = 30;

        /// <summary>
        /// 프로그램 시작 시 자동 감시
        /// </summary>
        public bool AutoStartMonitor { get; set; } = true;

        /// <summary>
        /// Windows 시작 시 자동 실행
        /// </summary>
        public bool RunWithWindows { get; set; } = false;

        /// <summary>
        /// 시작 시 트레이 최소화
        /// </summary>
        public bool StartMinimized { get; set; } = true;

        /// <summary>
        /// 로그 저장 여부
        /// </summary>
        public bool EnableLog { get; set; } = true;

        /// <summary>
        /// 최대 재시작 횟수
        /// 0 = 무제한
        /// </summary>
        public int MaxRestartCount { get; set; } = 0;

        public MonitorSetting()
        {
            Load();
        }

        /// <summary>
        /// config.ini 읽기
        /// </summary>
        public void Load()
        {
            IniFile ini = new IniFile("config.ini");

            ProcessName =
                ReadString(ini, "ProcessName", ProcessName);

            ProgramPath =
                ReadString(ini, "ProgramPath", ProgramPath);

            CheckInterval =
                ReadInt(ini, "CheckInterval", CheckInterval);

            HangTimeout =
                ReadInt(ini, "HangTimeout", HangTimeout);

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

        /// <summary>
        /// config.ini 저장
        /// </summary>
        public void Save()
        {
            IniFile ini = new IniFile("config.ini");

            ini.Write("ProcessName", ProcessName);
            ini.Write("ProgramPath", ProgramPath);
            ini.Write("CheckInterval", CheckInterval.ToString());
            ini.Write("HangTimeout", HangTimeout.ToString());
            ini.Write("RestartDelay", RestartDelay.ToString());
            ini.Write("AutoStartMonitor", AutoStartMonitor.ToString());
            ini.Write("RunWithWindows", RunWithWindows.ToString());
            ini.Write("StartMinimized", StartMinimized.ToString());
            ini.Write("EnableLog", EnableLog.ToString());
            ini.Write("MaxRestartCount", MaxRestartCount.ToString());
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