using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ONE_PATH.Utility.Model;

namespace ONE_PATH.Utility
{
    class EnvironmentHelper
    {
 

        #region 检查软件版本更新

        public static SoftVerInfoModel CheckLatestVersion()
        {
            SoftVerInfoModel softVerInfo = new SoftVerInfoModel();
            JsonObj result = WebAPI.Get("http://api.ieasn.com/?service=App.GetSoftEnv.GetSoftVer");
            if (result.Get("ret") == "200")
            {
                Dictionary<string, object> list = result.GetList();
                Dictionary<string, object> Data = (Dictionary<string, object>) list["data"];
                softVerInfo.DownUrl = Data["DownUrl"].ToString();
                softVerInfo.IsNow = Data["IsNow"].ToString();
                softVerInfo.ProductVersion = Data["ProductVersion"].ToString();
                softVerInfo.FileVersion = Data["FileVersion"].ToString();
            }

            return softVerInfo;
        }

        #endregion

 
    }
}