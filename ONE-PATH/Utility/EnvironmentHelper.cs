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
        public static EnvironmentModel GetEnvironmentPath()
        {
            EnvironmentModel model = new EnvironmentModel();
            JsonObj result = WebAPI.Get("http://api.ieasn.com/?service=App.GetPath.Cmder");
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

        public static void GetEnvironmentPathList()
        {
            JsonObj result = WebAPI.Get("http://api.ieasn.com/?service=App.GetSoftEnv.GetPathList");
            if (result.Get("ret") == "200")
            {
                Dictionary<string, object> dic = result.GetList();
                Dictionary<string, object> data = dic["data"] as Dictionary<string, object>;
                ArrayList ProdArrayList = data["DataRows"] as ArrayList;
                if (ProdArrayList.Count > 0) //判断所在是否存在
                {
                    for (int i = 0; i < ProdArrayList.Count; i++)
                    {
                        Dictionary<string, object> dic_listprods = ProdArrayList[i] as Dictionary<string, object>;
                        SoftInfo SoftInfo = new SoftInfo();
                        SoftInfo.SoftName = RueiConvert.ToString(dic_listprods["ProdID"]);
                        SoftInfo.SoftApi = RueiConvert.ToString(dic_listprods["ProdName"]);
                    }
                }
            }
        }
    }
}