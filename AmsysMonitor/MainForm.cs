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
        private readonly MonitorSetting setting;
        private readonly MonitorEngine engine;
        private readonly TrayService trayService;

        public MainForm()
        {
            InitializeComponent();

            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;

            setting = new MonitorSetting();
            engine = new MonitorEngine(setting);

            trayService = new TrayService();

            // 감시 시작
            engine.Start();

            Logger.Info("Amsys Monitor 시작");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            engine.Stop();
            trayService.Dispose();

            base.OnFormClosing(e);
        }
    }
}