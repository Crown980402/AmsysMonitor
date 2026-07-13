using System;
using System.Windows.Forms;
using AmsysMonitor.Models;
using AmsysMonitor.Services;
using AmsysMonitor.Utils;
using AmsysMonitor.Core;

namespace AmsysMonitor
{
    public partial class MainForm : Form
    {
        private readonly Timer monitorTimer;

        private readonly MonitorSetting setting;
        private readonly MonitorEngine engine;

        private bool isChecking = false;

        public MainForm()
        {
            InitializeComponent();

            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;

            setting = new MonitorSetting();
            engine = new MonitorEngine(setting);

            monitorTimer = new Timer();
            monitorTimer.Interval = setting.CheckInterval;
            monitorTimer.Tick += Timer_Tick;
            monitorTimer.Start();

            Logger.Info("Amsys Monitor 시작");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (isChecking)
                return;

            isChecking = true;

            try
            {
               engine.Check();
            }
            finally
            {
                isChecking = false;
            }
        }
    }
}