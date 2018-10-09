namespace ONE_PATH
{
    partial class MainPath
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPath));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel_AboutMe = new MetroFramework.Controls.MetroLink();
            this.linkLabel_DownUrl = new MetroFramework.Controls.MetroLink();
            this.Label_SoftName = new MetroFramework.Controls.MetroLabel();
            this.Label_Path = new MetroFramework.Controls.MetroLabel();
            this.MyPathBox = new MetroFramework.Controls.MetroTextBox();
            this.EnvCombSelect = new MetroFramework.Controls.MetroComboBox();
            this.B_Exit = new MetroFramework.Controls.MetroButton();
            this.B_StartSetEnv = new MetroFramework.Controls.MetroButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Label_SoftVersion = new MetroFramework.Controls.MetroLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Label_SoftVersion);
            this.panel1.Controls.Add(this.linkLabel_AboutMe);
            this.panel1.Controls.Add(this.linkLabel_DownUrl);
            this.panel1.Controls.Add(this.Label_SoftName);
            this.panel1.Controls.Add(this.Label_Path);
            this.panel1.Controls.Add(this.MyPathBox);
            this.panel1.Controls.Add(this.EnvCombSelect);
            this.panel1.Controls.Add(this.B_Exit);
            this.panel1.Controls.Add(this.B_StartSetEnv);
            this.panel1.Location = new System.Drawing.Point(-1, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 136);
            this.panel1.TabIndex = 1;
            // 
            // linkLabel_AboutMe
            // 
            this.linkLabel_AboutMe.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.linkLabel_AboutMe.Location = new System.Drawing.Point(323, 103);
            this.linkLabel_AboutMe.Name = "linkLabel_AboutMe";
            this.linkLabel_AboutMe.Size = new System.Drawing.Size(61, 23);
            this.linkLabel_AboutMe.TabIndex = 3;
            this.linkLabel_AboutMe.Text = "@RENNY";
            this.linkLabel_AboutMe.UseSelectable = true;
            this.linkLabel_AboutMe.Click += new System.EventHandler(this.linkLabel_AboutMe_Click);
            // 
            // linkLabel_DownUrl
            // 
            this.linkLabel_DownUrl.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.linkLabel_DownUrl.Location = new System.Drawing.Point(214, 103);
            this.linkLabel_DownUrl.Name = "linkLabel_DownUrl";
            this.linkLabel_DownUrl.Size = new System.Drawing.Size(103, 23);
            this.linkLabel_DownUrl.TabIndex = 2;
            this.linkLabel_DownUrl.Text = "点此下载最新版";
            this.linkLabel_DownUrl.UseSelectable = true;
            this.linkLabel_DownUrl.Click += new System.EventHandler(this.linkLabel_DownUrl_Click);
            // 
            // Label_SoftName
            // 
            this.Label_SoftName.AutoSize = true;
            this.Label_SoftName.Location = new System.Drawing.Point(20, 50);
            this.Label_SoftName.Name = "Label_SoftName";
            this.Label_SoftName.Size = new System.Drawing.Size(68, 19);
            this.Label_SoftName.TabIndex = 14;
            this.Label_SoftName.Text = "软件名称:";
            // 
            // Label_Path
            // 
            this.Label_Path.AutoSize = true;
            this.Label_Path.Location = new System.Drawing.Point(20, 10);
            this.Label_Path.Name = "Label_Path";
            this.Label_Path.Size = new System.Drawing.Size(68, 19);
            this.Label_Path.TabIndex = 2;
            this.Label_Path.Text = "程序路径:";
            // 
            // MyPathBox
            // 
            // 
            // 
            // 
            this.MyPathBox.CustomButton.Image = null;
            this.MyPathBox.CustomButton.Location = new System.Drawing.Point(268, 1);
            this.MyPathBox.CustomButton.Name = "";
            this.MyPathBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MyPathBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MyPathBox.CustomButton.TabIndex = 1;
            this.MyPathBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MyPathBox.CustomButton.UseSelectable = true;
            this.MyPathBox.CustomButton.Visible = false;
            this.MyPathBox.Lines = new string[0];
            this.MyPathBox.Location = new System.Drawing.Point(94, 6);
            this.MyPathBox.MaxLength = 32767;
            this.MyPathBox.Name = "MyPathBox";
            this.MyPathBox.PasswordChar = '\0';
            this.MyPathBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MyPathBox.SelectedText = "";
            this.MyPathBox.SelectionLength = 0;
            this.MyPathBox.SelectionStart = 0;
            this.MyPathBox.ShortcutsEnabled = true;
            this.MyPathBox.Size = new System.Drawing.Size(290, 23);
            this.MyPathBox.TabIndex = 13;
            this.MyPathBox.UseSelectable = true;
            this.MyPathBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MyPathBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // EnvCombSelect
            // 
            this.EnvCombSelect.FormattingEnabled = true;
            this.EnvCombSelect.ItemHeight = 23;
            this.EnvCombSelect.Location = new System.Drawing.Point(94, 40);
            this.EnvCombSelect.Name = "EnvCombSelect";
            this.EnvCombSelect.Size = new System.Drawing.Size(151, 29);
            this.EnvCombSelect.TabIndex = 5;
            this.EnvCombSelect.UseSelectable = true;
            // 
            // B_Exit
            // 
            this.B_Exit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.B_Exit.Location = new System.Drawing.Point(320, 42);
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Size = new System.Drawing.Size(63, 27);
            this.B_Exit.TabIndex = 12;
            this.B_Exit.Text = "退出";
            this.B_Exit.UseSelectable = true;
            this.B_Exit.Click += new System.EventHandler(this.B_Exit_Click);
            // 
            // B_StartSetEnv
            // 
            this.B_StartSetEnv.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.B_StartSetEnv.Location = new System.Drawing.Point(251, 42);
            this.B_StartSetEnv.Name = "B_StartSetEnv";
            this.B_StartSetEnv.Size = new System.Drawing.Size(63, 27);
            this.B_StartSetEnv.TabIndex = 6;
            this.B_StartSetEnv.Text = "开始";
            this.B_StartSetEnv.UseSelectable = true;
            this.B_StartSetEnv.Click += new System.EventHandler(this.B_StartSetEnv_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Label_SoftVersion
            // 
            this.Label_SoftVersion.AutoSize = true;
            this.Label_SoftVersion.Location = new System.Drawing.Point(20, 103);
            this.Label_SoftVersion.Name = "Label_SoftVersion";
            this.Label_SoftVersion.Size = new System.Drawing.Size(97, 19);
            this.Label_SoftVersion.TabIndex = 2;
            this.Label_SoftVersion.Text = "检查更新中……";
            // 
            // MainPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 198);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainPath";
            this.Text = "OnePath 系统环境一键配置";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroButton B_StartSetEnv;
        private MetroFramework.Controls.MetroTextBox MyPathBox;
        private MetroFramework.Controls.MetroComboBox EnvCombSelect;
        private MetroFramework.Controls.MetroButton B_Exit;
        private MetroFramework.Controls.MetroLabel Label_Path;
        private MetroFramework.Controls.MetroLabel Label_SoftName;
        private MetroFramework.Controls.MetroLink linkLabel_DownUrl;
        private MetroFramework.Controls.MetroLink linkLabel_AboutMe;
        private MetroFramework.Controls.MetroLabel Label_SoftVersion;
    }
}

