using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ONE_PATH
{
    public partial class MainPath : Form
    {
        public MainPath()
        {
            InitializeComponent();

            
        }


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

        private void button1_Click(object sender, EventArgs e)
        {
            SetPath(textBox1.Text);
        }
    }
}