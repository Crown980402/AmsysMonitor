using System;

namespace AmsysMonitor.Models
{
    /// <summary>
    /// 프로그램의 현재 상태 정보
    /// </summary>
    public class AppStatus
    {
        /// <summary>
        /// 프로그램 시작 시간
        /// </summary>
        public DateTime StartTime { get; set; } = DateTime.Now;

        /// <summary>
        /// 마지막 상태 검사 시간
        /// </summary>
        public DateTime LastCheckTime { get; set; }

        /// <summary>
        /// 마지막 재시작 시간
        /// </summary>
        public DateTime? LastRestartTime { get; set; }

        /// <summary>
        /// 총 재시작 횟수
        /// </summary>
        public int RestartCount { get; set; }

        /// <summary>
        /// 총 Crash 횟수
        /// </summary>
        public int CrashCount { get; set; }

        /// <summary>
        /// 메인 프로그램(Amsys.exe) 실행 여부
        /// </summary>
        public bool IsMainRunning { get; set; }

        /// <summary>
        /// Kocom 프로그램 실행 여부
        /// </summary>
        public bool IsKocomRunning { get; set; }

        /// <summary>
        /// 응답 여부
        /// </summary>
        public bool IsResponding { get; set; }

        /// <summary>
        /// 현재 감시 중 여부
        /// </summary>
        public bool IsMonitoring { get; set; } = true;

        /// <summary>
        /// 마지막 오류 내용
        /// </summary>
        public string LastError { get; set; } = string.Empty;

        /// <summary>
        /// 프로그램 가동 시간
        /// </summary>
        public TimeSpan Uptime => DateTime.Now - StartTime;
    }
}