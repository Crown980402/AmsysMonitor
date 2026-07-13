using System;
using System.Collections.Generic;

namespace AmsysMonitor.Services
{
    /// <summary>
    /// 일정 시간 동안 재시작 횟수를 제한하는 클래스
    /// </summary>
    public class RestartLimiter
    {
        // 최근 재시작 시간 저장
        private readonly Queue<DateTime> restartHistory = new Queue<DateTime>();

        // 제한 시간 (5분)
        private readonly TimeSpan limitPeriod = TimeSpan.FromMinutes(5);

        // 최대 허용 재시작 횟수
        private const int MaxRestartCount = 5;

        /// <summary>
        /// 재시작 가능 여부 확인
        /// </summary>
        public bool CanRestart()
        {
            DateTime now = DateTime.Now;

            // 5분이 지난 기록 제거
            while (restartHistory.Count > 0 &&
                   now - restartHistory.Peek() > limitPeriod)
            {
                restartHistory.Dequeue();
            }

            return restartHistory.Count < MaxRestartCount;
        }

        /// <summary>
        /// 재시작 기록
        /// </summary>
        public void RecordRestart()
        {
            restartHistory.Enqueue(DateTime.Now);
        }

        /// <summary>
        /// 현재 제한 시간 내 재시작 횟수
        /// </summary>
        public int RestartCount
        {
            get
            {
                return restartHistory.Count;
            }
        }
    }
}