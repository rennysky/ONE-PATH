using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ONE_PATH.Utility.Model;

namespace ONE_PATH.Utility
{
    class SetEnvironment
    {
        public void SetCmder(string SoftPath)
        {
            StartEnvironment("CMDER_HOME", SoftPath, AuthType.Machine.ToString());
            StartEnvironment("Path", "%CMDER_HOME%", AuthType.Machine.ToString());
        }

        public void SetNode(string SoftPath)
        {
            System.IO.DirectoryInfo global = new System.IO.DirectoryInfo(SoftPath + "\node_global");

            global.Create();
            System.IO.DirectoryInfo cache = new System.IO.DirectoryInfo(SoftPath + "\node_cache");
            cache.Create();
            StartEnvironment("NODE_PATH", SoftPath + "\node_global\node_modules", AuthType.Machine.ToString());
            StartEnvironment("Path", SoftPath + "\node_global", AuthType.User.ToString());
            StartCMD("npm config set prefix " + SoftPath + "\node_global");
            StartCMD("npm config set cache  " + SoftPath + "\node_cache");
        }

        public void SetJava(string SoftPath)
        {
            StartEnvironment("JAVA_HOME", SoftPath, AuthType.Machine.ToString());
            StartEnvironment("CLASSPATH", @".;%JAVA_HOME%\lib\dt.jar;%JAVA_HOME%\lib\tools.jar;",AuthType.Machine.ToString());
            StartEnvironment("Path", @"%JAVA_HOME%\bin;%JAVA_HOME%\jre\bin;", AuthType.Machine.ToString());
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

        #region CMD执行

        private void StartCMD(string cmdInput)
        {
            Console.WriteLine("请输入要执行的命令:");

            Process p = new Process();
            //设置要启动的应用程序
            p.StartInfo.FileName = "cmd.exe";
            //是否使用操作系统shell启动
            p.StartInfo.UseShellExecute = false;
            // 接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardInput = true;
            //输出信息
            p.StartInfo.RedirectStandardOutput = true;
            // 输出错误
            //不显示程序窗口
            p.StartInfo.CreateNoWindow = true;
            //启动程序
            p.Start();

            //向cmd窗口发送输入信息
            p.StandardInput.WriteLine(cmdInput + "&exit");

            p.StandardInput.AutoFlush = true;

            //获取输出信息
            string strOuput = p.StandardOutput.ReadToEnd();
            //等待程序执行完退出进程
            p.WaitForExit();
            p.Close();

            Console.WriteLine(strOuput);

            Console.ReadKey();
        }
        #endregion
    }
}



