using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ONE_PATH.Utility.Model;

namespace ONE_PATH.Utility
{
    class SetEnvironment
    {
        public void SetNode(string SoftPath)
        {
            StartEnvironment("CMDER_HOME", SoftPath, AuthType.Machine.ToString());
            StartEnvironment("Path", "%CMDER_HOME%", AuthType.Machine.ToString());
        }


        #region 写入系统变量

        private void SetMachinePath(string PathName, string pathValue)
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

        #region 写入用户环境变量

        private void SetUserPath(string PathName, string pathValue)
        {
            string pathlist;
            pathlist = Environment.GetEnvironmentVariable(PathName, EnvironmentVariableTarget.User);
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

        #region 创建新系统环境变量

        private void CreateMachinePath(string PathName, string pathValue)
        {
            Environment.SetEnvironmentVariable(PathName, pathValue, EnvironmentVariableTarget.Machine);
        }

        #endregion

        #region 创建新用户环境变量

        private void CreateUserPath(string PathName, string pathValue)
        {
            Environment.SetEnvironmentVariable(PathName, pathValue, EnvironmentVariableTarget.User);
        }

        #endregion

        #region 获取并配置所需环境变量

        private void StartEnvironment(string EnvKey, string EnvValue, string EnvAuth)
        {
            if (EnvAuth == "Machine")
            {
                try
                {
                    SetMachinePath(EnvKey, EnvValue);
                }
                catch (Exception e) //若没有相应文档，部或错误，尝试创建
                {
                    try
                    {
                        CreateMachinePath(EnvKey, EnvValue);
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show(e1.Message);
                    }
                }
            }

            if (EnvAuth == "User")
            {
                try
                {
                    SetUserPath(EnvKey, EnvValue);
                }
                catch (Exception e) //若没有相应文档，部或错误，尝试创建
                {
                    try
                    {
                        CreateUserPath(EnvKey, EnvValue);
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show(e1.Message);
                    }
                }
            }
        }

        #endregion
    }
}