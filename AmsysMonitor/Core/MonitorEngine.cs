using System;
using System.Windows.Forms;
using AmsysMonitor.Models;
using AmsysMonitor.Services;

namespace AmsysMonitor.Core
{
    public class MonitorEngine : IDisposable
    {
        private readonly MonitorSetting setting;
        private readonly HealthCheckService healthChecker;
        private readonly Timer timer;

        private bool isChecking;

        public MonitorEngine(MonitorSetting setting)
        {
            this.setting = setting;

            healthChecker = new HealthCheckService(setting);

            timer = new Timer
            {
                Interval = setting.CheckInterval
            };

            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (isChecking)
                return;

            isChecking = true;

            try
            {
                healthChecker.Check();
            }
            finally
            {
                isChecking = false;
            }
        }

        /// <summary>
        /// 감시 시작
        /// </summary>
        public void Start()
        {
            timer.Start();
        }

        /// <summary>
        /// 감시 중지
        /// </summary>
        public void Stop()
        {
            timer.Stop();
        }

        /// <summary>
        /// 설정 다시 읽기
        /// </summary>
        public void Reload()
        {
            Stop();

            setting.Load();

            timer.Interval = setting.CheckInterval;

            Start();
        }

        /// <summary>
        /// 현재 설정 반환
        /// </summary>
        public MonitorSetting Setting => setting;

        public void Dispose()
        {
            timer.Stop();
            timer.Dispose();
        }
    }
}