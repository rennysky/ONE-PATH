using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using ONE_PATH.Utility.Model;

namespace ONE_PATH
{ 
    public class EnvironmentHelper
    {
        #region 获取相应环境变量配置

       // public static EnvironmentModel GetEnvironmentPath(string SoftName)
       // {
           // EnvironmentModel model = new EnvironmentModel();
           // SoftVerInfoModel softVerInfo = new SoftVerInfoModel();
           // WebRequest wr = WebRequest.Create("http://api.ieasn.com/?service=App.GetPath." + SoftName);
           // Stream s = wr.GetResponse().GetResponseStream();
           // StreamReader sr = new StreamReader(s, Encoding.Default);
           // string all = sr.ReadToEnd(); //读取网站的数据
           // sr.Close();
           // s.Close();
           //// JsonObj result = JsonObj.Parse(all);

           // if (result.Get("ret") == "200")
           // {
           //     Dictionary<string, object> list = result.GetList();
           //     Dictionary<string, object> Data = (Dictionary<string, object>)list["data"];
           //     model.SystemPath = Data["SystemPath"].ToString();
           //     model.UserPath = Data["UserPath"].ToString();
           //     model.OtherKey = Data["OtherKey"].ToString();
           //     model.OtherValue = Data["OtherValue"].ToString();
           //     model.IsMachine = Data["IsMachine"].ToString();
           // }

           // return model;
       // }

        #endregion

        #region 获取云端所有软件列表

        public static ArrayList SoftList = new ArrayList();

        public static void GetEnvironmentPathList()
        {
            //WebRequest wr = WebRequest.Create("http://api.ieasn.com/?service=App.GetSoftEnv.GetPathList");
            //Stream s = wr.GetResponse().GetResponseStream();
            //StreamReader sr = new StreamReader(s, Encoding.Default);
            //string all = sr.ReadToEnd(); //读取网站的数据
            //sr.Close();
            //s.Close();
            ////JsonObj result = JsonObj.Parse(all);

            //if (result.Get("ret") == "200")
            //{
            //    Dictionary<string, object> dic = result.GetList();
            //    Dictionary<string, object> data = dic["data"] as Dictionary<string, object>;

            //    if (data.Count > 0)
            //    {
            //        foreach (var KeyList in data.Keys)
            //        {
            //            SoftList.Add(KeyList);
            //        }
            //    }
            //}
        }

        #endregion

        #region 检查软件版本更新

       // public static SoftVerInfoModel CheckLatestVersion()
       // {
           // SoftVerInfoModel softVerInfo = new SoftVerInfoModel();
           // //处理HttpWebRequest访问https有安全证书的问题（ 请求被中止: 未能创建 SSL/TLS 安全通道。）
           // ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
           // ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(CheckValidationResult);

           // WebRequest wr = WebRequest.Create("https://rennysky.github.io/ONE-PATH/web/update.json");
           // Stream s = wr.GetResponse().GetResponseStream();
           // StreamReader sr = new StreamReader(s, Encoding.Default);
           // string all = sr.ReadToEnd(); //读取网站的数据
           // sr.Close();
           // s.Close();
           //// JsonObj result = JsonObj.Parse(all);
           // if (result.Get("ret") == "200")
           // {
           //     Dictionary<string, object> list = result.GetList();
           //     Dictionary<string, object> Data = (Dictionary<string, object>)list["data"];
           //     softVerInfo.DownUrl = Data["DownUrl"].ToString();
           //     softVerInfo.IsNow = Data["IsNow"].ToString();
           //     softVerInfo.ProductVersion = Data["ProductVersion"].ToString();
           //     softVerInfo.FileVersion = Data["FileVersion"].ToString();
           // }

           // return softVerInfo;
       // }
        #endregion
    }
}