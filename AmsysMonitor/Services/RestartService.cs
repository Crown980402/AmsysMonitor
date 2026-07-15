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
            // 재시작 대기시간 확인
            if ((DateTime.Now - lastRestart).TotalSeconds <
                setting.RestartDelay)
            {
                Logger.Warning(
                    $"재시작 대기 중 ({setting.RestartDelay}초)");

                return false;
            }

            // 경로 확인
            if (string.IsNullOrWhiteSpace(setting.ProgramPath))
            {
                Logger.Error("ProgramPath가 설정되지 않았습니다.");

                return false;
            }

            // 파일 존재 확인
            if (!File.Exists(setting.ProgramPath))
            {
                Logger.Error(
                    $"실행 파일을 찾을 수 없습니다.\r\n{setting.ProgramPath}");

                return false;
            }

            try
            {
                Logger.Info("Amsys2Kocom.exe 재시작 시도");

                Process.Start(new ProcessStartInfo
                {
                    FileName = setting.ProgramPath,
                    UseShellExecute = true,
                    Verb = "runas"
                });

                lastRestart = DateTime.Now;

                Logger.Info("Amsys2Kocom.exe 재시작 성공");

                return true;
            }
            catch (Exception ex)
            {
                Logger.Error($"재시작 실패 : {ex.Message}");
                Logger.Error(ex.ToString());

                return false;
            }
        }
    }
}