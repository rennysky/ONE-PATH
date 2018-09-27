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
            this.MyPathBox = new System.Windows.Forms.TextBox();
            this.B_StartSetEnv = new System.Windows.Forms.Button();
            this.B_Exit = new System.Windows.Forms.Button();
            this.Label_Path = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MyPathBox
            // 
            this.MyPathBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MyPathBox.Location = new System.Drawing.Point(97, 12);
            this.MyPathBox.Name = "MyPathBox";
            this.MyPathBox.Size = new System.Drawing.Size(255, 26);
            this.MyPathBox.TabIndex = 0;
            // 
            // B_StartSetEnv
            // 
            this.B_StartSetEnv.BackColor = System.Drawing.SystemColors.Highlight;
            this.B_StartSetEnv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_StartSetEnv.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.B_StartSetEnv.ForeColor = System.Drawing.Color.White;
            this.B_StartSetEnv.Location = new System.Drawing.Point(220, 49);
            this.B_StartSetEnv.Name = "B_StartSetEnv";
            this.B_StartSetEnv.Size = new System.Drawing.Size(62, 26);
            this.B_StartSetEnv.TabIndex = 1;
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
            this.B_Exit.Location = new System.Drawing.Point(288, 49);
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Size = new System.Drawing.Size(64, 26);
            this.B_Exit.TabIndex = 2;
            this.B_Exit.Text = "退出";
            this.B_Exit.UseVisualStyleBackColor = false;
            this.B_Exit.Click += new System.EventHandler(this.B_Exit_Click);
            // 
            // Label_Path
            // 
            this.Label_Path.AutoSize = true;
            this.Label_Path.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Path.Location = new System.Drawing.Point(12, 15);
            this.Label_Path.Name = "Label_Path";
            this.Label_Path.Size = new System.Drawing.Size(79, 20);
            this.Label_Path.TabIndex = 3;
            this.Label_Path.Text = "程序路径：";
            // 
            // MainPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(373, 87);
            this.Controls.Add(this.Label_Path);
            this.Controls.Add(this.B_Exit);
            this.Controls.Add(this.B_StartSetEnv);
            this.Controls.Add(this.MyPathBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainPath";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OnePath 系统环境一键配置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MyPathBox;
        private System.Windows.Forms.Button B_StartSetEnv;
        private System.Windows.Forms.Button B_Exit;
        private System.Windows.Forms.Label Label_Path;
    }
}

