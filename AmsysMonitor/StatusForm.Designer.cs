namespace AmsysMonitor
{
    partial class StatusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusForm));
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.lblMainStatus = new System.Windows.Forms.Label();
            this.lblKocomTitle = new System.Windows.Forms.Label();
            this.lblKocomStatus = new System.Windows.Forms.Label();
            this.lblRespondTitle = new System.Windows.Forms.Label();
            this.lblResponding = new System.Windows.Forms.Label();
            this.lblLastCheckTitle = new System.Windows.Forms.Label();
            this.lblLastCheck = new System.Windows.Forms.Label();
            this.lblLastRestartTitle = new System.Windows.Forms.Label();
            this.lblLastRestart = new System.Windows.Forms.Label();
            this.lblRestartTitle = new System.Windows.Forms.Label();
            this.lblRestartCount = new System.Windows.Forms.Label();
            this.lblCrashTitle = new System.Windows.Forms.Label();
            this.lblCrashCount = new System.Windows.Forms.Label();
            this.lblUpTimeTitle = new System.Windows.Forms.Label();
            this.lblUpTime = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMainTitle.Location = new System.Drawing.Point(15, 32);
            this.lblMainTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(115, 16);
            this.lblMainTitle.TabIndex = 0;
            this.lblMainTitle.Text = "메인 프로그램";
            // 
            // lblMainStatus
            // 
            this.lblMainStatus.AutoSize = true;
            this.lblMainStatus.Location = new System.Drawing.Point(230, 32);
            this.lblMainStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMainStatus.Name = "lblMainStatus";
            this.lblMainStatus.Size = new System.Drawing.Size(81, 16);
            this.lblMainStatus.TabIndex = 1;
            this.lblMainStatus.Text = "● 실행 중";
            // 
            // lblKocomTitle
            // 
            this.lblKocomTitle.AutoSize = true;
            this.lblKocomTitle.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblKocomTitle.Location = new System.Drawing.Point(15, 81);
            this.lblKocomTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKocomTitle.Name = "lblKocomTitle";
            this.lblKocomTitle.Size = new System.Drawing.Size(138, 16);
            this.lblKocomTitle.TabIndex = 2;
            this.lblKocomTitle.Text = "Kocom 프로그램";
            // 
            // lblKocomStatus
            // 
            this.lblKocomStatus.AutoSize = true;
            this.lblKocomStatus.Location = new System.Drawing.Point(230, 80);
            this.lblKocomStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKocomStatus.Name = "lblKocomStatus";
            this.lblKocomStatus.Size = new System.Drawing.Size(81, 16);
            this.lblKocomStatus.TabIndex = 3;
            this.lblKocomStatus.Text = "● 실행 중";
            // 
            // lblRespondTitle
            // 
            this.lblRespondTitle.AutoSize = true;
            this.lblRespondTitle.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRespondTitle.Location = new System.Drawing.Point(15, 125);
            this.lblRespondTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRespondTitle.Name = "lblRespondTitle";
            this.lblRespondTitle.Size = new System.Drawing.Size(81, 16);
            this.lblRespondTitle.TabIndex = 4;
            this.lblRespondTitle.Text = "응답 상태";
            // 
            // lblResponding
            // 
            this.lblResponding.AutoSize = true;
            this.lblResponding.Location = new System.Drawing.Point(230, 126);
            this.lblResponding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResponding.Name = "lblResponding";
            this.lblResponding.Size = new System.Drawing.Size(60, 16);
            this.lblResponding.TabIndex = 5;
            this.lblResponding.Text = "● 정상";
            // 
            // lblLastCheckTitle
            // 
            this.lblLastCheckTitle.AutoSize = true;
            this.lblLastCheckTitle.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLastCheckTitle.Location = new System.Drawing.Point(15, 187);
            this.lblLastCheckTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastCheckTitle.Name = "lblLastCheckTitle";
            this.lblLastCheckTitle.Size = new System.Drawing.Size(98, 16);
            this.lblLastCheckTitle.TabIndex = 6;
            this.lblLastCheckTitle.Text = "마지막 검사";
            // 
            // lblLastCheck
            // 
            this.lblLastCheck.AutoSize = true;
            this.lblLastCheck.Location = new System.Drawing.Point(18, 211);
            this.lblLastCheck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastCheck.Name = "lblLastCheck";
            this.lblLastCheck.Size = new System.Drawing.Size(15, 16);
            this.lblLastCheck.TabIndex = 7;
            this.lblLastCheck.Text = "-";
            // 
            // lblLastRestartTitle
            // 
            this.lblLastRestartTitle.AutoSize = true;
            this.lblLastRestartTitle.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLastRestartTitle.Location = new System.Drawing.Point(15, 235);
            this.lblLastRestartTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastRestartTitle.Name = "lblLastRestartTitle";
            this.lblLastRestartTitle.Size = new System.Drawing.Size(115, 16);
            this.lblLastRestartTitle.TabIndex = 8;
            this.lblLastRestartTitle.Text = "마지막 재시작";
            // 
            // lblLastRestart
            // 
            this.lblLastRestart.AutoSize = true;
            this.lblLastRestart.Location = new System.Drawing.Point(18, 260);
            this.lblLastRestart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastRestart.Name = "lblLastRestart";
            this.lblLastRestart.Size = new System.Drawing.Size(15, 16);
            this.lblLastRestart.TabIndex = 9;
            this.lblLastRestart.Text = "-";
            // 
            // lblRestartTitle
            // 
            this.lblRestartTitle.AutoSize = true;
            this.lblRestartTitle.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRestartTitle.Location = new System.Drawing.Point(15, 289);
            this.lblRestartTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRestartTitle.Name = "lblRestartTitle";
            this.lblRestartTitle.Size = new System.Drawing.Size(81, 16);
            this.lblRestartTitle.TabIndex = 10;
            this.lblRestartTitle.Text = "총 재시작";
            // 
            // lblRestartCount
            // 
            this.lblRestartCount.AutoSize = true;
            this.lblRestartCount.Location = new System.Drawing.Point(24, 312);
            this.lblRestartCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRestartCount.Name = "lblRestartCount";
            this.lblRestartCount.Size = new System.Drawing.Size(15, 16);
            this.lblRestartCount.TabIndex = 11;
            this.lblRestartCount.Text = "0";
            // 
            // lblCrashTitle
            // 
            this.lblCrashTitle.AutoSize = true;
            this.lblCrashTitle.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCrashTitle.Location = new System.Drawing.Point(15, 336);
            this.lblCrashTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCrashTitle.Name = "lblCrashTitle";
            this.lblCrashTitle.Size = new System.Drawing.Size(78, 16);
            this.lblCrashTitle.TabIndex = 12;
            this.lblCrashTitle.Text = "총 Crash";
            // 
            // lblCrashCount
            // 
            this.lblCrashCount.AutoSize = true;
            this.lblCrashCount.Location = new System.Drawing.Point(24, 359);
            this.lblCrashCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCrashCount.Name = "lblCrashCount";
            this.lblCrashCount.Size = new System.Drawing.Size(15, 16);
            this.lblCrashCount.TabIndex = 13;
            this.lblCrashCount.Text = "0";
            // 
            // lblUpTimeTitle
            // 
            this.lblUpTimeTitle.AutoSize = true;
            this.lblUpTimeTitle.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUpTimeTitle.Location = new System.Drawing.Point(15, 385);
            this.lblUpTimeTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpTimeTitle.Name = "lblUpTimeTitle";
            this.lblUpTimeTitle.Size = new System.Drawing.Size(81, 16);
            this.lblUpTimeTitle.TabIndex = 14;
            this.lblUpTimeTitle.Text = "가동 시간";
            // 
            // lblUpTime
            // 
            this.lblUpTime.AutoSize = true;
            this.lblUpTime.Location = new System.Drawing.Point(15, 409);
            this.lblUpTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpTime.Name = "lblUpTime";
            this.lblUpTime.Size = new System.Drawing.Size(65, 16);
            this.lblUpTime.TabIndex = 15;
            this.lblUpTime.Text = "00:00:00";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(353, 445);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 31);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(19, 166);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(771, 3);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // StatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 489);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblUpTime);
            this.Controls.Add(this.lblUpTimeTitle);
            this.Controls.Add(this.lblCrashCount);
            this.Controls.Add(this.lblCrashTitle);
            this.Controls.Add(this.lblRestartCount);
            this.Controls.Add(this.lblRestartTitle);
            this.Controls.Add(this.lblLastRestart);
            this.Controls.Add(this.lblLastRestartTitle);
            this.Controls.Add(this.lblLastCheck);
            this.Controls.Add(this.lblLastCheckTitle);
            this.Controls.Add(this.lblResponding);
            this.Controls.Add(this.lblRespondTitle);
            this.Controls.Add(this.lblKocomStatus);
            this.Controls.Add(this.lblKocomTitle);
            this.Controls.Add(this.lblMainStatus);
            this.Controls.Add(this.lblMainTitle);
            this.Font = new System.Drawing.Font("굴림", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amsys Monitor 상태";
            this.Load += new System.EventHandler(this.StatusForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Label lblMainStatus;
        private System.Windows.Forms.Label lblKocomTitle;
        private System.Windows.Forms.Label lblKocomStatus;
        private System.Windows.Forms.Label lblRespondTitle;
        private System.Windows.Forms.Label lblResponding;
        private System.Windows.Forms.Label lblLastCheckTitle;
        private System.Windows.Forms.Label lblLastCheck;
        private System.Windows.Forms.Label lblLastRestartTitle;
        private System.Windows.Forms.Label lblLastRestart;
        private System.Windows.Forms.Label lblRestartTitle;
        private System.Windows.Forms.Label lblRestartCount;
        private System.Windows.Forms.Label lblCrashTitle;
        private System.Windows.Forms.Label lblCrashCount;
        private System.Windows.Forms.Label lblUpTimeTitle;
        private System.Windows.Forms.Label lblUpTime;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}