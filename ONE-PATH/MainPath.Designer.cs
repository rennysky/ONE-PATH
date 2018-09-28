﻿namespace ONE_PATH
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
            this.MyPathBox = new System.Windows.Forms.TextBox();
            this.B_StartSetEnv = new System.Windows.Forms.Button();
            this.B_Exit = new System.Windows.Forms.Button();
            this.Label_Path = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label_SoftVersion = new System.Windows.Forms.Label();
            this.Label_SoftName = new System.Windows.Forms.Label();
            this.EnvCombSelect = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MyPathBox
            // 
            this.MyPathBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MyPathBox.Location = new System.Drawing.Point(121, 70);
            this.MyPathBox.Name = "MyPathBox";
            this.MyPathBox.Size = new System.Drawing.Size(255, 26);
            this.MyPathBox.TabIndex = 3;
            // 
            // B_StartSetEnv
            // 
            this.B_StartSetEnv.BackColor = System.Drawing.SystemColors.Highlight;
            this.B_StartSetEnv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_StartSetEnv.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.B_StartSetEnv.ForeColor = System.Drawing.Color.White;
            this.B_StartSetEnv.Location = new System.Drawing.Point(244, 107);
            this.B_StartSetEnv.Name = "B_StartSetEnv";
            this.B_StartSetEnv.Size = new System.Drawing.Size(62, 26);
            this.B_StartSetEnv.TabIndex = 6;
            this.B_StartSetEnv.Text = "开始";
            this.B_StartSetEnv.UseVisualStyleBackColor = false;
            this.B_StartSetEnv.Click += new System.EventHandler(this.B_StartSetEnv_Click);
            // 
            // B_Exit
            // 
            this.B_Exit.BackColor = System.Drawing.SystemColors.Highlight;
            this.B_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Exit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.B_Exit.ForeColor = System.Drawing.Color.White;
            this.B_Exit.Location = new System.Drawing.Point(312, 107);
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Size = new System.Drawing.Size(64, 26);
            this.B_Exit.TabIndex = 7;
            this.B_Exit.Text = "退出";
            this.B_Exit.UseVisualStyleBackColor = false;
            this.B_Exit.Click += new System.EventHandler(this.B_Exit_Click);
            // 
            // Label_Path
            // 
            this.Label_Path.AutoSize = true;
            this.Label_Path.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Path.Location = new System.Drawing.Point(47, 73);
            this.Label_Path.Name = "Label_Path";
            this.Label_Path.Size = new System.Drawing.Size(68, 20);
            this.Label_Path.TabIndex = 2;
            this.Label_Path.Text = "程序路径:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Label_SoftVersion);
            this.panel1.Controls.Add(this.Label_SoftName);
            this.panel1.Controls.Add(this.EnvCombSelect);
            this.panel1.Controls.Add(this.MyPathBox);
            this.panel1.Controls.Add(this.Label_Path);
            this.panel1.Controls.Add(this.B_StartSetEnv);
            this.panel1.Controls.Add(this.B_Exit);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 217);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Label_SoftVersion
            // 
            this.Label_SoftVersion.AutoSize = true;
            this.Label_SoftVersion.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_SoftVersion.Location = new System.Drawing.Point(3, 192);
            this.Label_SoftVersion.Name = "Label_SoftVersion";
            this.Label_SoftVersion.Size = new System.Drawing.Size(88, 17);
            this.Label_SoftVersion.TabIndex = 6;
            this.Label_SoftVersion.Text = "获取版本中……";
            // 
            // Label_SoftName
            // 
            this.Label_SoftName.AutoSize = true;
            this.Label_SoftName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_SoftName.Location = new System.Drawing.Point(47, 109);
            this.Label_SoftName.Name = "Label_SoftName";
            this.Label_SoftName.Size = new System.Drawing.Size(68, 20);
            this.Label_SoftName.TabIndex = 4;
            this.Label_SoftName.Text = "软件名称:";
            // 
            // EnvCombSelect
            // 
            this.EnvCombSelect.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EnvCombSelect.FormattingEnabled = true;
            this.EnvCombSelect.Location = new System.Drawing.Point(121, 107);
            this.EnvCombSelect.Name = "EnvCombSelect";
            this.EnvCombSelect.Size = new System.Drawing.Size(108, 28);
            this.EnvCombSelect.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(430, 220);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainPath";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OnePath 系统环境一键配置";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox MyPathBox;
        private System.Windows.Forms.Button B_StartSetEnv;
        private System.Windows.Forms.Button B_Exit;
        private System.Windows.Forms.Label Label_Path;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox EnvCombSelect;
        private System.Windows.Forms.Label Label_SoftName;
        private System.Windows.Forms.Label Label_SoftVersion;
        private System.Windows.Forms.Timer timer1;
    }
}

