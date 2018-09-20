using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ONE_PATH.Utility.Model;

namespace ONE_PATH.Utility
{
    class Environmenthelper
    {
        public void GetEnvironmentPath()
        {
            EnvironmentModel model = new EnvironmentModel();
            JsonObj result = WebAPI.Get("http://api.ieasn.com/?service=App.GetPath.Cmder");
            if (result.Get("ret") == "200")
            {
                Dictionary<string, object> list = result.GetList();
                Dictionary<string, object> Data = (Dictionary<string, object>)list["data"];
                model.Auth = Data["Auth"].ToString();
                model.PATH = Data["PATH"].ToString();
                model.MainPkgPath = Data["MainPkgPath"].ToString();
            }
        }
    }
}
