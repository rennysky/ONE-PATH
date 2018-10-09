using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONE_PATH.Utility
{
    public class UtilitySoft
    {
        //创建一个绝对路径
        string SavePath = AppDomain.CurrentDomain.BaseDirectory;

        public void Node(string file)
        {
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(file + "node_global");

            di.Create();
            System.IO.DirectoryInfo di2 = new System.IO.DirectoryInfo(file + "node_cache");
            di2.Create();


        }
    }
}