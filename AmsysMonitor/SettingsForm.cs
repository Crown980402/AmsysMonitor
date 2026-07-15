using System;
using System.Windows.Forms;
using AmsysMonitor.Core;
using AmsysMonitor.Models;

namespace AmsysMonitor
{
    public partial class SettingsForm : Form
    {
        private readonly MonitorSetting setting;
        private readonly MonitorEngine engine;

        public SettingsForm(MonitorSetting setting, MonitorEngine engine)
        {
            InitializeComponent();

            this.setting = setting;
            this.engine = engine;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            numCheckInterval.Value = setting.CheckInterval / 1000;
            numHangTimeout.Value = setting.HangTimeout;
            numRestartDelay.Value = setting.RestartDelay;
            numMaxRestart.Value = setting.MaxRestartCount;

            chkLog.Checked = setting.EnableLog;
            chkStartup.Checked = setting.RunWithWindows;
            chkMinimized.Checked = setting.StartMinimized;

            txtProgramPath.Text = setting.ProgramPath;
        }

        private void SettingsForm_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void SettingsForm_Load_2(object sender, EventArgs e)
        {

        }
    }
}