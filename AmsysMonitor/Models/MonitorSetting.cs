namespace AmsysMonitor.Models
{
    /// <summary>
    /// 프로그램 전체 설정
    /// </summary>
    public class MonitorSetting
    {
        /// <summary>
        /// 감시할 프로세스 이름 (.exe 제외)
        /// </summary>
        public string ProcessName { get; set; } = "Amsys2Kocom";

        /// <summary>
        /// 실행파일 전체 경로
        /// </summary>
        public string ProgramPath { get; set; }
            = @"C:\Omnisystem\Amsys21\Amsys2Kocom.exe";

        /// <summary>
        /// 감시 주기(ms)
        /// </summary>
        public int CheckInterval { get; set; } = 5000;

        /// <summary>
        /// 재실행 최소 대기시간(초)
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
        /// 시작 시 트레이로 최소화
        /// </summary>
        public bool StartMinimized { get; set; } = true;

        /// <summary>
        /// 로그 저장 여부
        /// </summary>
        public bool EnableLog { get; set; } = true;

        /// <summary>
        /// 최대 재실행 횟수 (0 = 무제한)
        /// </summary>
        public int MaxRestartCount { get; set; } = 0;
    }
}