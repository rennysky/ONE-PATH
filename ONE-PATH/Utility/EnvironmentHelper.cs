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
        #region 获取相应环境变量配置

        public static EnvironmentModel GetEnvironmentPath(string SoftName)
        {
            EnvironmentModel model = new EnvironmentModel();
            //JsonObj result = WebAPI.Get("http://api.ieasn.com/?service=App.GetPath." + SoftName);
            // if (result.Get("ret") == "200")
            // {
            //IO读取
            string JsonStr = GetMyJson();
            JsonObj result = JsonObj.Parse(JsonStr);
            Dictionary<string, object> dic = result.GetList();
            Dictionary<string, object> Data = (Dictionary<string, object>) dic[SoftName];
            model.SystemPath = Data["SystemPath"].ToString();
            model.SystemPathTag = Data["SystemPathTag"].ToString();
            model.UserPathTag = Data["UserPathTag"].ToString();
            model.UserPath = Data["UserPath"].ToString();
            model.OtherKey = Data["OtherKey"].ToString();
            model.OtherValueTag = Data["OtherValueTag"].ToString();
            model.OtherValue = Data["OtherValue"].ToString();
            model.OtherIsMachine = Data["OtherIsMachine"].ToString();

            model.IsSpecial = Data["IsSpecial"].ToString();
            // }

            return model;
        }

        #endregion

        #region 获取所有软件列表

        public static ArrayList SoftList = new ArrayList();

        public static void GetEnvironmentPathList()
        {
            //IO读取
            string JsonStr = GetMyJson();
            JsonObj result = JsonObj.Parse(JsonStr);
            Dictionary<string, object> dic = result.GetList();
            //JsonObj result = WebAPI.Get("http://api.ieasn.com/?service=App.GetSoftEnv.GetPathList");
            //if (result.Get("ret") == "200")
            //{

            //    Dictionary<string, object> data = dic["data"] as Dictionary<string, object>;

            if (dic.Count > 0)
            {
                foreach (var KeyList in dic.Keys)
                {
                    SoftList.Add(KeyList);
                }
            }

            //}
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

        #region json读写

        private static string GetMyJson()
        {
            //创建一个绝对路径
            string SavePath = AppDomain.CurrentDomain.BaseDirectory;
            using (FileStream fsRead = new FileStream(string.Format("{0}\\softconfig.json", SavePath), FileMode.Open))
            {
                //读取加转换
                int fsLen = (int) fsRead.Length;
                byte[] heByte = new byte[fsLen];
                int r = fsRead.Read(heByte, 0, heByte.Length);
                return System.Text.Encoding.UTF8.GetString(heByte);
            }
        }

        #endregion
    }
}