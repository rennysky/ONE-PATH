using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ONE_PATH.Utility.Model
{
    #region 系统环境目录信息

    public class EnvironmentModel
    {
        [JsonIgnore]
        /// <summary>
        /// 系统文件目录
        /// </summary>
        public string SystemPath;

        /// <summary>
        /// 用户文件目录
        /// </summary>
        public string UserPath;

        /// <summary>
        /// 其他环境变量
        /// </summary>
        public string OtherKey;

        /// <summary>
        /// 其他环境变量值
        /// </summary>
        public string OtherValue;

        /// <summary>
        /// 其他环境变量是否为系统
        /// </summary>
        public string IsMachine;
    }

    #endregion

    #region 软件信息

    public class SoftInfo
    {
        /// <summary>
        /// 产品名称
        /// </summary>

        public string SoftName { get; set; }

        /// <summary>
        /// 具体api
        /// </summary>
        public string SoftApi { set; get; }
    }

    #endregion

    #region 最新软件版本信息

    public class SoftVerInfo
    {
        /// <summary>
        /// 软件版本
        /// </summary>

        public string FileVersion { get; set; }

        /// <summary>
        /// 软件版本
        /// </summary>

        public string ProductVersion { get; set; }

        /// <summary>
        /// 是否需要强制升级
        /// </summary>
        public string IsNow { set; get; }

        /// <summary>
        /// 软件下载链接
        /// </summary>
        public string DownUrl { set; get; }

        #endregion
    }
}