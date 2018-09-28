using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ONE_PATH.Utility.Model;

namespace ONE_PATH.Utility
{
    class EnvironmentHelper
    {
        #region 获取相应环境变量配置

        public static EnvironmentModel GetEnvironmentPath(string SoftName)
        {
            EnvironmentModel model = new EnvironmentModel();
            JsonObj result = WebAPI.Get("http://api.ieasn.com/?service=App.GetPath." + SoftName);
            if (result.Get("ret") == "200")
            {
                Dictionary<string, object> list = result.GetList();
                Dictionary<string, object> Data = (Dictionary<string, object>) list["data"];
                model.SystemPath = Data["SystemPath"].ToString();
                model.UserPath = Data["UserPath"].ToString();
                model.OtherKey = Data["OtherKey"].ToString();
                model.OtherValue = Data["OtherValue"].ToString();
                model.IsMachine = Data["IsMachine"].ToString();
            }

            return model;
        }

        #endregion

        #region 获取云端所有软件列表

        public static ArrayList SoftList = new ArrayList();

        public static void GetEnvironmentPathList()
        {
            JsonObj result = WebAPI.Get("http://api.ieasn.com/?service=App.GetSoftEnv.GetPathList");
            if (result.Get("ret") == "200")
            {
                Dictionary<string, object> dic = result.GetList();
                Dictionary<string, object> data = dic["data"] as Dictionary<string, object>;

                if (data.Count > 0)
                {
                    foreach (var KeyList in data.Keys)
                    {
                        SoftList.Add(KeyList);
                    }
                }
            }
        }

        #endregion

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