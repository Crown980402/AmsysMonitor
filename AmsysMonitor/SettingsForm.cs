using System;
using System.Windows.Forms;
using AmsysMonitor.Core;
using AmsysMonitor.Models;
using System.IO;
using AmsysMonitor.Services;

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            setting.CheckInterval = (int)numCheckInterval.Value * 1000;
            setting.HangTimeout = (int)numHangTimeout.Value;
            setting.RestartDelay = (int)numRestartDelay.Value;
            setting.MaxRestartCount = (int)numMaxRestart.Value;

            setting.EnableLog = chkLog.Checked;
            setting.RunWithWindows = chkStartup.Checked;
            setting.StartMinimized = chkMinimized.Checked;

            setting.ProgramPath = txtProgramPath.Text;

            setting.Save();

            StartupService startup = new StartupService();
            startup.Apply(setting);

            engine.Reload();

            MessageBox.Show(
                "설정이 저장되었습니다.",
                "Amsys Monitor",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "실행 파일 (*.exe)|*.exe";
                dialog.Title = "Amsys2Kocom.exe 선택";

                if (File.Exists(txtProgramPath.Text))
                {
                    dialog.InitialDirectory =
                        Path.GetDirectoryName(txtProgramPath.Text);

                    dialog.FileName =
                        Path.GetFileName(txtProgramPath.Text);
                }

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtProgramPath.Text = dialog.FileName;
                }
            }
        }
    }
}