using System;
using System.Diagnostics;
using AmsysMonitor.Models;
using AmsysMonitor.Utils;

namespace AmsysMonitor.Services
{
    public class HealthCheckService
    {
        private readonly ProcessWatcher processWatcher;
        private readonly HangDetector hangDetector;
        private readonly RestartService restartService;
        private readonly CrashRecorder crashRecorder;
        private readonly RestartLimiter restartLimiter;

        private readonly AppStatus appStatus;

        public AppStatus Status => appStatus;

        public HealthCheckService(MonitorSetting setting)
        {
            processWatcher = new ProcessWatcher(setting);
            hangDetector = new HangDetector();
            restartService = new RestartService(setting);
            crashRecorder = new CrashRecorder();
            restartLimiter = new RestartLimiter();

            appStatus = new AppStatus();
        }

        public void Check()
        {
            appStatus.LastCheckTime = DateTime.Now;

            appStatus.IsMainRunning =
                processWatcher.IsMainRunning();

            if (!appStatus.IsMainRunning)
            {
                Logger.Warning("Amsys.exe가 실행 중이 아닙니다.");
                return;
            }

            appStatus.IsKocomRunning =
                processWatcher.IsKocomRunning();

            if (!appStatus.IsKocomRunning)
            {
                Logger.Warning("Amsys2Kocom.exe 종료 감지");

                if (restartLimiter.CanRestart())
                {
                    restartLimiter.RecordRestart();

                    appStatus.RestartCount++;
                    appStatus.LastRestartTime = DateTime.Now;

                    restartService.Restart();
                }
                else
                {
                    Logger.Error("재시작 제한 횟수를 초과했습니다.");
                }

                return;
            }

            Process process = processWatcher.GetKocomProcess();

            if (process == null)
                return;

            appStatus.IsResponding =
                hangDetector.IsResponding(process.ProcessName);

            if (!appStatus.IsResponding)
            {
                Logger.Warning("Amsys2Kocom 응답 없음");

                appStatus.CrashCount++;

                crashRecorder.Record(
                    process,
                    "Not Responding");

                try
                {
                    process.Kill();

                    Logger.Warning("프로세스 강제 종료");
                }
                catch (Exception ex)
                {
                    Logger.Error(ex.ToString());
                }

                if (restartLimiter.CanRestart())
                {
                    restartLimiter.RecordRestart();

                    appStatus.RestartCount++;
                    appStatus.LastRestartTime = DateTime.Now;

                    restartService.Restart();
                }
                else
                {
                    Logger.Error("재시작 제한 횟수를 초과했습니다.");
                }
            }
        }
    }
}