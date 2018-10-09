using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Web.Script;
using System.Windows.Forms;
using ONE_PATH.Utility;
using ONE_PATH.Utility.Model;
using MetroFramework;
using MetroFramework.Forms;


namespace ONE_PATH
{
    public partial class MainPath : MetroForm
    {
        public MainPath()
        {
            InitializeComponent();

            RegisterEvents();
        }



        #region 执行环境变量方法

        private void SetEnvMethod()
        {
            SetEnvironment set=new SetEnvironment();
             
            switch (EnvCombSelect.Text)
            {
                case "Cmder":
                    set.SetCmder(MyPathBox.Text);
                    break;
                case "Node":
                    set.SetNode(MyPathBox.Text);
                    break;
                default: MessageBox.Show("234234");
                    break;
            }
            
              
        }

        #endregion

        #region 控件操作

        /// <summary>
        /// 执行一键注入注册表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void B_StartSetEnv_Click(object sender, EventArgs e)
        {
            if (MyPathBox.Text != "")
            {
                SetEnvMethod();
            }
            else
            {
                MessageBox.Show("请输入相应程序地址");
            }
        }

        /// <summary>
        /// 退出程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void B_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


        #region 检查版本更新

        public SoftVerInfoModel SoftVerInfo { get; set; }

        /// <summary>
        /// 检测版本
        /// </summary>
        public void CheckVersion()
        {
            SoftVerInfo = EnvironmentHelper.CheckLatestVersion();
            string LocalFileVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            string LocalProductVersion = Application.ProductVersion.ToString();
            Label_SoftVersion.Text = "本地版本:" + LocalProductVersion + "最新版本:" + SoftVerInfo.ProductVersion;
            if (LocalProductVersion != SoftVerInfo.ProductVersion)
            {
                MessageBox.Show("当前不是最新版本" + "\r\n" + "为获取良好体验建议您更新为最新版本", "OnePath版本提示:", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 定时检测
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            CheckVersion();
        }


        /// <summary>
        /// 打开下载链接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel_DownUrl_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(SoftVerInfo.DownUrl);
            }
            catch (Exception exception)
            {
                MessageBox.Show("无法正常打开下载地址！" + "\r\n" + "请在浏览器里手动打开" + "\r\n" + SoftVerInfo.DownUrl);
            }
        }


        private void linkLabel_AboutMe_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://uno.moe");
        }

        #endregion

        #region 启动注册事件

        private void RegisterEvents()
        {
             
        }

        #endregion
    }
}