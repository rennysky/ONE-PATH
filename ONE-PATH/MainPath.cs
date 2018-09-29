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

        #region 写入环境变量

        public void SetPath(string PathName, string pathValue)
        {
            string pathlist;
            pathlist = Environment.GetEnvironmentVariable(PathName, EnvironmentVariableTarget.Machine);
            string[] list = pathlist.Split(';');
            bool isPathExist = false;
            foreach (string item in list)
            {
                if (item == pathValue)
                    isPathExist = true;
            }

            if (!isPathExist)
            {
                Environment.SetEnvironmentVariable(PathName, pathlist + ";" + pathValue,
                    EnvironmentVariableTarget.Machine);
            }
        }

        #endregion

        #region 创建新环境变量

        public void CreatePath(string PathName, string pathValue)
        {
            if (pathValue == "soft_path")
            {
                pathValue = MyPathBox.Text;
            }

            Environment.SetEnvironmentVariable(PathName, pathValue, EnvironmentVariableTarget.Machine);
        }

        #endregion

        #region 获取并配置所需环境变量

        public EnvironmentModel EnvironmentInfo { get; set; }

        private void SetEnvironment(string EnvKey, string EnvValue)
        {
            //SetPath(textBox1.Text);

            if (EnvValue == "soft_path")
            {
                EnvValue = MyPathBox.Text;
            }

            try
            {
                SetPath(EnvKey, EnvValue);
            }
            catch (Exception e) //若没有相应文档，部或错误，尝试创建
            {
                try
                {
                    CreatePath(EnvKey, EnvValue);
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }
            }
        }

        #endregion

        #region 执行环境变量方法

        private void SetEnvMethod()
        {
            try
            {
                EnvironmentInfo =
                    EnvironmentHelper.GetEnvironmentPath(EnvCombSelect.SelectedValue.ToString()); //选用combo的选中值

                SetEnvironment("PATH", EnvironmentInfo.SystemPath);
                //SetEnvironment("PATH", EnvironmentInfo.UserPath);
                SetEnvironment(EnvironmentInfo.OtherKey, EnvironmentInfo.OtherValue);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                MessageBox.Show("环境搭建完成！请检验！");
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
        /// 是否正常打开下载链接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel_DownUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception exception)
            {
                MessageBox.Show("无法正常打开下载地址！" + "\r\n" + "请在浏览器里手动打开" + "\r\n" + SoftVerInfo.DownUrl);
            }
        }

        /// <summary>
        /// 打开下载链接
        /// </summary>
        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited   
            // to true.  
            linkLabel_DownUrl.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            ////with a URL:  
            System.Diagnostics.Process.Start(SoftVerInfo.DownUrl);
        }

        #endregion

        #region 启动注册事件

        private void RegisterEvents()
        {
            EnvironmentHelper.GetEnvironmentPathList();
            EnvCombSelect.DataSource = EnvironmentHelper.SoftList;
        }

        #endregion

        private void linkLabel_AboutMe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://uno.moe");
        }

        private void Label_SoftVersion_Click(object sender, EventArgs e)
        {

        }

 
    }
}