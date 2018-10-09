using Starksoft.Aspen.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace ONE_PATH.Utility
{
    /// <summary>
    /// 代理类
    /// </summary>
    public class ProxyClass
    {
        /// <summary>
        /// 代理类型
        /// </summary>
        public ProxyType ProxyType
        { get; set; }

        /// <summary>
        /// 代理地址
        /// </summary>
        public string ProxyHost
        { get; set; }

        /// <summary>
        /// 代理端口
        /// </summary>
        public int ProxyPort
        { get; set; }

        ///// <summary>
        ///// 代理用户名
        ///// </summary>
        //public string ProxyUserName
        //{ get; set; }

        ///// <summary>
        ///// 代理用户密码
        ///// </summary>
        //public string ProxyPassWord
        //{ get; set; }
    }
    public static class WebAPI
    {

        /// <summary>
        /// 当前的代理类
        /// </summary>
        public static ProxyClass CurrProxyClass;
        /// <summary>
        /// 接口验证Token
        /// </summary>
        public static string ValidateHead
        {
            get; set;
        }

        private static int timeOut = 30 * 1000;
        /// <summary>
        /// 初始化默认接口调用超时时间
        /// </summary>
        public static int TimeOut
        {
            get
            {
                return timeOut;
            }
            set
            {
                timeOut = value;
            }
        }

        public static void InitialWebAPI(ProxyClass proxyClass)
        {
            if (proxyClass != null && proxyClass.ProxyType != ProxyType.NONE)
            {
                CurrProxyClass = proxyClass;
            }
        }

        /// <summary>
        /// 获取指定接口地址返回的对象
        /// </summary>
        public static T Get<T>(string url)
        {
            string json = sGet(url, true);

            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
        }

        /// <summary>
        /// Get方式获取数据
        /// </summary>
        /// <param name="url">接口地址</param>
        /// <param name="Parameter">接口参数</param>
        /// <returns>返回参数集合Dictionary</returns>
        public static JsonObj Get(string url, bool IsUseJsonHeader = true)
        {
            return JsonObj.Parse(sGet(url, IsUseJsonHeader));
        }

        /// <summary>
        /// Get方式获取数据
        /// </summary>
        /// <param name="url">接口地址</param>
        /// <param name="Parameter">接口参数</param>
        /// <returns>返回参数集合Dictionary</returns>
        public static JsonObj Get(string url, Dictionary<string, string> Parameters, bool IsUseJsonHeader = true)
        {
            //格式化参数Url
            if (Parameters != null && Parameters.Count > 0)
            {
                StringBuilder strPar = new StringBuilder("?");

                foreach (KeyValuePair<string, string> kvp in Parameters)
                {
                    strPar.Append(string.Format("{0}={1}&", kvp.Key, kvp.Value));
                }

                url += strPar.ToString(0, strPar.Length - 1);
            }

            return JsonObj.Parse(sGet(url, IsUseJsonHeader));
        }

        /// <summary>
        /// 提交数据给指定接口，并获取反馈结果
        /// </summary>
        public static T Post<T>(string url, object postData)
        {
            string postDataJson = Newtonsoft.Json.JsonConvert.SerializeObject(postData);

            string result = sPost(url, postDataJson, true);

            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(result);
        }

        /// <summary>
        /// Post方式获取数据
        /// </summary>
        /// <param name="url">接口地址</param>
        /// <param name="Parameters">接口参数</param>
        /// <returns>返回参数集合Dictionary</returns>
        public static JsonObj Post(string url, Dictionary<string, string> Parameters, bool IsUseJsonHeader = true)
        {
            string postData = (new JavaScriptSerializer()).Serialize(Parameters);

            return JsonObj.Parse(sPost(url, postData, IsUseJsonHeader));
        }

        /// <summary>
        /// Post方式获取数据
        /// </summary>
        /// <param name="url">接口地址</param>
        /// <param name="JsonParameter">JSON格式的字符串</param>
        /// <returns>返回参数集合Dictionary</returns>
        public static JsonObj Post(string url, string postData, bool IsUseJsonHeader = true)
        {
            return JsonObj.Parse(sPost(url, postData, IsUseJsonHeader));
        }

        public static string sPost(string url, string postData, bool IsUseJsonHeader = true)
        {
            return sPost(url, postData, timeOut, IsUseJsonHeader);
        }

        public static string sPost(string url, string postData, int timeOut, bool IsUseJsonHeader = true)
        {
            try
            {
                string result = GetClient(timeOut, IsUseJsonHeader).OpenRead(url, postData);
                return result;
            }
            catch (System.Exception ex)
            {
                return ex.ToString();
            }
        }

        public static string sGet(string url, bool IsUseJsonHeader = true)
        {
            return sGet(url, timeOut, IsUseJsonHeader);
        }

        public static string sGet(string url, int timeOut, bool IsUseJsonHeader = true)
        {
            try
            {
                string result = GetClient(timeOut, IsUseJsonHeader).OpenRead(url);
                return result;
            }
            catch (System.Exception e)
            {
                return "";
            }
        }

        public static HttpProc.WebClient GetClient(int timeOut = 30 * 1000, bool IsUseJsonHeader = true)
        {
            HttpProc.WebClient webClient = new HttpProc.WebClient(IsUseJsonHeader);
            if (CurrProxyClass != null && CurrProxyClass.ProxyType != ProxyType.NONE)
            {
                switch (CurrProxyClass.ProxyType)
                {
                    case ProxyType.SOCKS5:
                        webClient.Proxy = new Socks5ProxyClient(CurrProxyClass.ProxyHost, CurrProxyClass.ProxyPort);
                        break;
                    case ProxyType.HTTP:
                        webClient.Proxy = new HttpProxyClient(CurrProxyClass.ProxyHost, CurrProxyClass.ProxyPort);
                        break;
                }
            }
            webClient.TimeOut = timeOut;
            webClient.RueiAuthHead = "bearer " + ValidateHead;
            webClient.AddAuthorizationHeader();
            webClient.Encoding = Encoding.UTF8;

            return webClient;
        }
    }
}
