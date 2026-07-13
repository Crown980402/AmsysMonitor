using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using AmsysMonitor.Models;

namespace AmsysMonitor
{
    public partial class StatusForm : Form
    {
        private readonly AppStatus status;
        private readonly Timer refreshTimer;

        public StatusForm(AppStatus status)
        {
            InitializeComponent();

            this.status = status;

            refreshTimer = new Timer();
            refreshTimer.Interval = 1000;
            refreshTimer.Tick += RefreshTimer_Tick;
            refreshTimer.Start();

            RefreshStatus();
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            RefreshStatus();
        }

        private void RefreshStatus()
        {
            lblMainStatus.Text =
                status.IsMainRunning ? "🟢 실행중" : "🔴 종료";

            lblKocomStatus.Text =
                status.IsKocomRunning ? "🟢 실행중" : "🔴 종료";

            lblResponding.Text =
                status.IsResponding ? "🟢 정상" : "🟠 응답 없음";

            lblLastCheck.Text =
                status.LastCheckTime == DateTime.MinValue
                ? "-"
                : status.LastCheckTime.ToString("yyyy-MM-dd HH:mm:ss");

            lblLastRestart.Text =
                status.LastRestartTime?.ToString("yyyy-MM-dd HH:mm:ss") ?? "-";

            lblRestartCount.Text =
                status.RestartCount.ToString();

            lblCrashCount.Text =
                status.CrashCount.ToString();

            lblUptime.Text =
                status.Uptime.ToString(@"dd\.hh\:mm\:ss");
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            string file =
                Path.Combine(
                    Application.StartupPath,
                    "MonitorLog.txt");

            if (File.Exists(file))
                Process.Start("notepad.exe", file);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            string file =
                Path.Combine(
                    Application.StartupPath,
                    "config.ini");

            if (File.Exists(file))
                Process.Start("notepad.exe", file);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshStatus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}