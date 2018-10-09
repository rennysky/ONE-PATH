using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ONE_PATH.Utility.Model
{
    #region 最新软件版本信息

    public class SoftVerInfoModel
    {
        /// <summary>
        /// 软件版本
        /// </summary>

        public string FileVersion { get; set; }

        /// <summary>
        /// 程序集版本
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