using System;
using System.Diagnostics;
using AmsysMonitor.Models;
using AmsysMonitor.Utils;

namespace AmsysMonitor.Services
{
    public class ProcessWatcher
    {
        private readonly MonitorSetting setting;
        private readonly RestartService restartService;

        private DateTime hangStart = DateTime.MinValue;

        public ProcessWatcher(MonitorSetting setting)
        {
            this.setting = setting;
            restartService = new RestartService(setting);
        }

        public void Check()
        {
            try
            {
                Process[] amsys =
                    Process.GetProcessesByName("Amsys");

                Process[] kocom =
                    Process.GetProcessesByName(setting.ProcessName);

                // 메인 프로그램도 없으면 아무 것도 하지 않음
                if (amsys.Length == 0)
                {
                    Logger.Warning("Amsys.exe가 실행 중이 아닙니다.");
                    return;
                }

                // Kocom만 죽은 경우
                if (kocom.Length == 0)
                {
                    Logger.Warning("Amsys2Kocom.exe 종료 감지");

                    restartService.Restart();

                    return;
                }

                CheckResponding(kocom[0]);
            }
            catch (Exception ex)
            {
                Logger.Error(ex.ToString());
            }
        }

        private void CheckResponding(Process process)
        {
            if (process.Responding)
            {
                hangStart = DateTime.MinValue;
                return;
            }

            if (hangStart == DateTime.MinValue)
            {
                hangStart = DateTime.Now;
                Logger.Warning("응답 없음 감지");
                return;
            }

            if ((DateTime.Now - hangStart).TotalSeconds >= 30)
            {
                Logger.Warning("30초 이상 응답 없음");

                try
                {
                    process.Kill();

                    Logger.Warning("프로세스 강제 종료");

                    restartService.Restart();
                }
                catch (Exception ex)
                {
                    Logger.Error(ex.ToString());
                }

                hangStart = DateTime.MinValue;
            }
        }
    }
}