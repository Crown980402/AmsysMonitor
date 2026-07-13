using System;
using System.Diagnostics;

namespace AmsysMonitor.Services
{
    public class HangDetector
    {
        /// <summary>
        /// 프로세스가 정상적으로 응답하는지 확인
        /// </summary>
        /// <param name="processName">확장자를 제외한 프로세스 이름</param>
        /// <returns>true = 정상, false = 응답 없음 또는 실행 안 됨</returns>
        public bool IsResponding(string processName)
        {
            try
            {
                Process[] processes = Process.GetProcessesByName(processName);

                if (processes.Length == 0)
                    return false;

                return processes[0].Responding;
            }
            catch
            {
                return false;
            }
        }
    }
}