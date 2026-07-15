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

        // 이벤트
        public event EventHandler StatusClicked;
        public event EventHandler SettingsClicked;
        public event EventHandler ExitClicked;

        public TrayService()
        {
            menu = new ContextMenuStrip();

            menu.Items.Add("상태 보기", null, (s, e) => StatusClicked?.Invoke(this, EventArgs.Empty));
            menu.Items.Add("설정", null, (s, e) => SettingsClicked?.Invoke(this, EventArgs.Empty));
            menu.Items.Add(new ToolStripSeparator());
            menu.Items.Add("로그 열기", null, OnOpenLog);
            menu.Items.Add(new ToolStripSeparator());
            menu.Items.Add("종료", null, (s, e) => ExitClicked?.Invoke(this, EventArgs.Empty));

            trayIcon = new NotifyIcon
            {
                Icon = System.Drawing.SystemIcons.Application,
                Text = "Amsys Monitor",
                Visible = true,
                ContextMenuStrip = menu
            };

            trayIcon.DoubleClick += (s, e) =>
            {
                StatusClicked?.Invoke(this, EventArgs.Empty);
            };

            trayIcon.ShowBalloonTip(
                3000,
                "Amsys Monitor",
                "백그라운드 감시를 시작했습니다.",
                ToolTipIcon.Info);
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
                MessageBox.Show(
                    "로그 파일이 없습니다.",
                    "Amsys Monitor",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        public void ShowBalloon(string title, string message, ToolTipIcon icon = ToolTipIcon.Info)
        {
            trayIcon.ShowBalloonTip(
                3000,
                title,
                message,
                icon);
        }

        public void Dispose()
        {
            trayIcon.Visible = false;

            trayIcon.Dispose();
            menu.Dispose();
        }
    }
}