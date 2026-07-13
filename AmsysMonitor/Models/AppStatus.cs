using System;

namespace AmsysMonitor.Models
{
    /// <summary>
    /// 프로그램의 현재 상태 정보
    /// </summary>
    public class AppStatus
    {
        public DateTime StartTime { get; set; } = DateTime.Now;

        public DateTime LastCheckTime { get; set; }

        public DateTime? LastRestartTime { get; set; }

        public int RestartCount { get; set; }

        public int CrashCount { get; set; }

        public bool IsMainRunning { get; set; }

        public bool IsKocomRunning { get; set; }

        public bool IsResponding { get; set; }

        /// <summary>
        /// 프로그램 가동 시간
        /// </summary>
        public TimeSpan Uptime => DateTime.Now - StartTime;
    }
}