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
        private readonly StartupService startupService;

        public MainForm()
        {
            InitializeComponent();

            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;

            setting = new MonitorSetting();

            startupService = new StartupService();
            startupService.Apply(setting);

            engine = new MonitorEngine(setting);

            trayService = new TrayService();

            engine.Start();

            Logger.Info("Amsys Monitor 시작");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            engine.Dispose();
            trayService.Dispose();

            base.OnFormClosing(e);
        }
    }
}