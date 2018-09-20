﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
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

        public void SetPath(string pathValue)
        {
            string pathlist;
            pathlist = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.Machine);
            string[] list = pathlist.Split(';');
            bool isPathExist = false;
            foreach (string item in list)
            {
                if (item == pathValue)
                    isPathExist = true;
            }

            if (!isPathExist)
            {
                Environment.SetEnvironmentVariable("PATH", pathlist + ";" + pathValue,
                    EnvironmentVariableTarget.Machine);
            }
        }

        #endregion

        #region 获取所需配置变量

        public EnvironmentModel EnvironmentInfo { get; set; }

        private void B_StartSetEnv_Click(object sender, EventArgs e)
        {
            //SetPath(textBox1.Text);
            EnvironmentInfo = EnvironmentHelper.GetEnvironmentPath();
        }

        #endregion
    }
}