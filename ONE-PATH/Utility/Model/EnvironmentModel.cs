using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ONE_PATH.Utility.Model
{
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
}