using System;
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
        }

        private void StatusForm_Load(object sender, EventArgs e)
        {
            RefreshStatus();

            refreshTimer.Start();
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            RefreshStatus();
        }

        private void RefreshStatus()
        {
            lblMainStatus.Text =
                status.IsMainRunning ? "● 실행 중" : "● 종료";

            lblKocomStatus.Text =
                status.IsKocomRunning ? "● 실행 중" : "● 종료";

            lblResponding.Text =
                status.IsResponding ? "● 정상" : "● 응답 없음";

            lblLastCheck.Text =
                status.LastCheckTime == DateTime.MinValue
                    ? "-"
                    : status.LastCheckTime.ToString("yyyy-MM-dd HH:mm:ss");

            lblLastRestart.Text =
                status.LastRestartTime.HasValue
                    ? status.LastRestartTime.Value.ToString("yyyy-MM-dd HH:mm:ss")
                    : "-";

            lblRestartCount.Text =
                status.RestartCount.ToString();

            lblCrashCount.Text =
                status.CrashCount.ToString();

            lblUpTime.Text =
                status.Uptime.ToString(@"dd\.hh\:mm\:ss");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            refreshTimer.Stop();
            refreshTimer.Dispose();

            base.OnFormClosing(e);
        }
    }
}