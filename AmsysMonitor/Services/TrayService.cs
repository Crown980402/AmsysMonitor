using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AmsysMonitor.Services
{
    public class TrayService : IDisposable
    {
        private readonly NotifyIcon trayIcon;
        private readonly ContextMenuStrip menu;

        public TrayService()
        {
            menu = new ContextMenuStrip();

            menu.Items.Add("상태 보기", null, OnStatus);
            menu.Items.Add("로그 열기", null, OnOpenLog);
            menu.Items.Add(new ToolStripSeparator());
            menu.Items.Add("종료", null, OnExit);

            trayIcon = new NotifyIcon
            {
                Icon = System.Drawing.SystemIcons.Application,
                Text = "Amsys Monitor",
                Visible = true,
                ContextMenuStrip = menu
            };

            trayIcon.DoubleClick += OnStatus;

            trayIcon.ShowBalloonTip(
                3000,
                "Amsys Monitor",
                "백그라운드 감시를 시작했습니다.",
                ToolTipIcon.Info);
        }

        private void OnStatus(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Amsys Monitor가 정상 동작 중입니다.",
                "상태",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void OnOpenLog(object sender, EventArgs e)
        {
            string logFile = Path.Combine(
                Application.StartupPath,
                "MonitorLog.txt");

            if (File.Exists(logFile))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = logFile,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("로그 파일이 없습니다.");
            }
        }

        private void OnExit(object sender, EventArgs e)
        {
            trayIcon.Visible = false;
            Application.Exit();
        }

        public void Dispose()
        {
            trayIcon.Dispose();
            menu.Dispose();
        }
    }
}