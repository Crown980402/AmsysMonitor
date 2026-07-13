using System;
using System.Windows.Forms;
using AmsysMonitor.Models;
using AmsysMonitor.Services;

namespace AmsysMonitor.Core
{
    public class MonitorEngine
    {
        private readonly ProcessWatcher watcher;
        private readonly Timer timer;
        private bool isChecking = false;

        public MonitorEngine(MonitorSetting setting)
        {
            watcher = new ProcessWatcher(setting);

            timer = new Timer();
            timer.Interval = setting.CheckInterval;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (isChecking)
                return;

            isChecking = true;

            try
            {
                watcher.Check();
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

        public void Check()
        {
            watcher.Check();
        }
    }
}