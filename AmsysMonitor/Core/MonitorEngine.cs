using System;
using System.Windows.Forms;
using AmsysMonitor.Models;
using AmsysMonitor.Services;

namespace AmsysMonitor.Core
{
    public class MonitorEngine : IDisposable
    {
        private readonly HealthCheckService healthChecker;
        private readonly Timer timer;

        private bool isChecking;

        public MonitorEngine(MonitorSetting setting)
        {
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

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        public void Dispose()
        {
            timer.Stop();
            timer.Dispose();
        }
    }
}