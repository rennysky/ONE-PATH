using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ONE_PATH.Utility.Model;

namespace ONE_PATH.Utility
{
    public class SetEnvironmentHelper
    {
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
                //pathValue = MyPathBox.Text;
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
                //EnvValue = MyPathBox.Text;
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
                //EnvironmentInfo = EnvironmentHelper.GetEnvironmentPath(EnvCombSelect.SelectedValue.ToString()); //选用combo的选中值

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
    }
}
