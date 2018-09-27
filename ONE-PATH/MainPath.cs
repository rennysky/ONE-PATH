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

namespace ONE_PATH
{
    public partial class MainPath : Form
    {
        public MainPath()
        {
            InitializeComponent();
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

        #region 获取所需配置变量

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
            catch (Exception exception)
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

        private void B_StartSetEnv_Click(object sender, EventArgs e)
        {
            EnvironmentInfo = EnvironmentHelper.GetEnvironmentPath();
            try
            {
                SetEnvironment("PATH",EnvironmentInfo.SystemPath);
                //SetEnvironment("PATH", EnvironmentInfo.UserPath);
                SetEnvironment(EnvironmentInfo.OtherKey, EnvironmentInfo.OtherValue);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}