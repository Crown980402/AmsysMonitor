using System;
using System.Windows.Forms;
using AmsysMonitor.Core;
using AmsysMonitor.Models;
using AmsysMonitor.Services;
using AmsysMonitor.Utils;

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

            // 설정 로드
            setting = new MonitorSetting();

            // 시작 프로그램 적용
            startupService = new StartupService();
            startupService.Apply(setting);

            // 감시 엔진 생성
            engine = new MonitorEngine(setting);

            // 트레이 생성
            trayService = new TrayService();

            // 트레이 이벤트 연결
            trayService.StatusClicked += TrayService_StatusClicked;
            trayService.SettingsClicked += TrayService_SettingsClicked;
            trayService.ExitClicked += TrayService_ExitClicked;

            // 감시 시작
            engine.Start();

            Logger.Info("Amsys Monitor 시작");
        }

        /// <summary>
        /// 상태 보기
        /// </summary>
        private void TrayService_StatusClicked(object sender, EventArgs e)
        {
            using (StatusForm form =
                new StatusForm(engine.HealthChecker.Status))
            {
                form.ShowDialog();
            }
        }

        /// <summary>
        /// 설정 열기
        /// </summary>
        private void TrayService_SettingsClicked(object sender, EventArgs e)
        {
            using (SettingsForm form = new SettingsForm(setting, engine))
            {
                form.ShowDialog();
            }
        }

        /// <summary>
        /// 프로그램 종료
        /// </summary>
        private void TrayService_ExitClicked(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            engine.Dispose();
            trayService.Dispose();

            base.OnFormClosing(e);
        }
    }
}