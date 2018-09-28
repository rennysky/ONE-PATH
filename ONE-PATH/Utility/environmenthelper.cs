using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ONE_PATH.Utility.Model;

namespace ONE_PATH.Utility
{
    class EnvironmentHelper
    {
        public static EnvironmentModel GetEnvironmentPath(string SoftName)
        {
            EnvironmentModel model = new EnvironmentModel();
            JsonObj result = WebAPI.Get("http://api.ieasn.com/?service=App.GetPath."+SoftName);
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
    }
}