namespace AmsysMonitor
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.lblCheckInterval = new System.Windows.Forms.Label();
            this.lblHangTimeout = new System.Windows.Forms.Label();
            this.lblMaxRestart = new System.Windows.Forms.Label();
            this.lblRestartDelay = new System.Windows.Forms.Label();
            this.lblProgramPath = new System.Windows.Forms.Label();
            this.numCheckInterval = new System.Windows.Forms.NumericUpDown();
            this.numHangTimeout = new System.Windows.Forms.NumericUpDown();
            this.numRestartDelay = new System.Windows.Forms.NumericUpDown();
            this.numMaxRestart = new System.Windows.Forms.NumericUpDown();
            this.chkLog = new System.Windows.Forms.CheckBox();
            this.chkStartup = new System.Windows.Forms.CheckBox();
            this.chkMinimized = new System.Windows.Forms.CheckBox();
            this.txtProgramPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCheckInterval_sec = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCheckInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHangTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRestartDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxRestart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCheckInterval
            // 
            this.lblCheckInterval.AutoSize = true;
            this.lblCheckInterval.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCheckInterval.Location = new System.Drawing.Point(21, 22);
            this.lblCheckInterval.Name = "lblCheckInterval";
            this.lblCheckInterval.Size = new System.Drawing.Size(81, 16);
            this.lblCheckInterval.TabIndex = 0;
            this.lblCheckInterval.Text = "감시 주기";
            this.lblCheckInterval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHangTimeout
            // 
            this.lblHangTimeout.AutoSize = true;
            this.lblHangTimeout.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblHangTimeout.Location = new System.Drawing.Point(21, 60);
            this.lblHangTimeout.Name = "lblHangTimeout";
            this.lblHangTimeout.Size = new System.Drawing.Size(115, 16);
            this.lblHangTimeout.TabIndex = 1;
            this.lblHangTimeout.Text = "응답없음 시간";
            this.lblHangTimeout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaxRestart
            // 
            this.lblMaxRestart.AutoSize = true;
            this.lblMaxRestart.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMaxRestart.Location = new System.Drawing.Point(21, 136);
            this.lblMaxRestart.Name = "lblMaxRestart";
            this.lblMaxRestart.Size = new System.Drawing.Size(138, 16);
            this.lblMaxRestart.TabIndex = 2;
            this.lblMaxRestart.Text = "최대 재시작 횟수";
            this.lblMaxRestart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRestartDelay
            // 
            this.lblRestartDelay.AutoSize = true;
            this.lblRestartDelay.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRestartDelay.Location = new System.Drawing.Point(21, 100);
            this.lblRestartDelay.Name = "lblRestartDelay";
            this.lblRestartDelay.Size = new System.Drawing.Size(98, 16);
            this.lblRestartDelay.TabIndex = 3;
            this.lblRestartDelay.Text = "재시작 대기";
            this.lblRestartDelay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProgramPath
            // 
            this.lblProgramPath.AutoSize = true;
            this.lblProgramPath.Font = new System.Drawing.Font("굴림", 12F);
            this.lblProgramPath.Location = new System.Drawing.Point(22, 321);
            this.lblProgramPath.Name = "lblProgramPath";
            this.lblProgramPath.Size = new System.Drawing.Size(108, 16);
            this.lblProgramPath.TabIndex = 4;
            this.lblProgramPath.Text = "프로그램 경로";
            // 
            // numCheckInterval
            // 
            this.numCheckInterval.Location = new System.Drawing.Point(193, 20);
            this.numCheckInterval.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numCheckInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCheckInterval.Name = "numCheckInterval";
            this.numCheckInterval.Size = new System.Drawing.Size(120, 21);
            this.numCheckInterval.TabIndex = 5;
            this.numCheckInterval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numHangTimeout
            // 
            this.numHangTimeout.Location = new System.Drawing.Point(193, 58);
            this.numHangTimeout.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numHangTimeout.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numHangTimeout.Name = "numHangTimeout";
            this.numHangTimeout.Size = new System.Drawing.Size(120, 21);
            this.numHangTimeout.TabIndex = 6;
            this.numHangTimeout.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numRestartDelay
            // 
            this.numRestartDelay.Location = new System.Drawing.Point(193, 97);
            this.numRestartDelay.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numRestartDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRestartDelay.Name = "numRestartDelay";
            this.numRestartDelay.Size = new System.Drawing.Size(120, 21);
            this.numRestartDelay.TabIndex = 7;
            this.numRestartDelay.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // numMaxRestart
            // 
            this.numMaxRestart.Location = new System.Drawing.Point(193, 134);
            this.numMaxRestart.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numMaxRestart.Name = "numMaxRestart";
            this.numMaxRestart.Size = new System.Drawing.Size(120, 21);
            this.numMaxRestart.TabIndex = 8;
            // 
            // chkLog
            // 
            this.chkLog.AutoSize = true;
            this.chkLog.Location = new System.Drawing.Point(24, 198);
            this.chkLog.Name = "chkLog";
            this.chkLog.Size = new System.Drawing.Size(76, 16);
            this.chkLog.TabIndex = 9;
            this.chkLog.Text = "로그 저장";
            this.chkLog.UseVisualStyleBackColor = true;
            // 
            // chkStartup
            // 
            this.chkStartup.AutoSize = true;
            this.chkStartup.Location = new System.Drawing.Point(24, 232);
            this.chkStartup.Name = "chkStartup";
            this.chkStartup.Size = new System.Drawing.Size(147, 16);
            this.chkStartup.TabIndex = 10;
            this.chkStartup.Text = "Windows 시작 시 실행";
            this.chkStartup.UseVisualStyleBackColor = true;
            // 
            // chkMinimized
            // 
            this.chkMinimized.AutoSize = true;
            this.chkMinimized.Location = new System.Drawing.Point(24, 267);
            this.chkMinimized.Name = "chkMinimized";
            this.chkMinimized.Size = new System.Drawing.Size(156, 16);
            this.chkMinimized.TabIndex = 11;
            this.chkMinimized.Text = "시작 시 트레이로 최소화";
            this.chkMinimized.UseVisualStyleBackColor = true;
            // 
            // txtProgramPath
            // 
            this.txtProgramPath.Location = new System.Drawing.Point(24, 352);
            this.txtProgramPath.Name = "txtProgramPath";
            this.txtProgramPath.Size = new System.Drawing.Size(289, 21);
            this.txtProgramPath.TabIndex = 12;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(340, 352);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 13;
            this.btnBrowse.Text = "찾아보기";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(234, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(383, 420);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCheckInterval_sec
            // 
            this.lblCheckInterval_sec.AutoSize = true;
            this.lblCheckInterval_sec.Font = new System.Drawing.Font("굴림", 12F);
            this.lblCheckInterval_sec.Location = new System.Drawing.Point(319, 22);
            this.lblCheckInterval_sec.Name = "lblCheckInterval_sec";
            this.lblCheckInterval_sec.Size = new System.Drawing.Size(39, 16);
            this.lblCheckInterval_sec.TabIndex = 16;
            this.lblCheckInterval_sec.Text = "[초]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F);
            this.label2.Location = new System.Drawing.Point(319, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "[초]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F);
            this.label3.Location = new System.Drawing.Point(319, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "[초]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F);
            this.label4.Location = new System.Drawing.Point(319, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "[회]";
            // 
            // SettingsForm
            // 
            this.ClientSize = new System.Drawing.Size(741, 455);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCheckInterval_sec);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtProgramPath);
            this.Controls.Add(this.chkMinimized);
            this.Controls.Add(this.chkStartup);
            this.Controls.Add(this.chkLog);
            this.Controls.Add(this.numMaxRestart);
            this.Controls.Add(this.numRestartDelay);
            this.Controls.Add(this.numHangTimeout);
            this.Controls.Add(this.numCheckInterval);
            this.Controls.Add(this.lblProgramPath);
            this.Controls.Add(this.lblRestartDelay);
            this.Controls.Add(this.lblMaxRestart);
            this.Controls.Add(this.lblHangTimeout);
            this.Controls.Add(this.lblCheckInterval);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Amsys Monitor";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCheckInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHangTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRestartDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxRestart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lblCheckInterval;
        private System.Windows.Forms.Label lblHangTimeout;
        private System.Windows.Forms.Label lblMaxRestart;
        private System.Windows.Forms.Label lblRestartDelay;
        private System.Windows.Forms.Label lblProgramPath;
        private System.Windows.Forms.NumericUpDown numCheckInterval;
        private System.Windows.Forms.NumericUpDown numHangTimeout;
        private System.Windows.Forms.NumericUpDown numRestartDelay;
        private System.Windows.Forms.NumericUpDown numMaxRestart;
        private System.Windows.Forms.CheckBox chkLog;
        private System.Windows.Forms.CheckBox chkStartup;
        private System.Windows.Forms.CheckBox chkMinimized;
        private System.Windows.Forms.TextBox txtProgramPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCheckInterval_sec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}