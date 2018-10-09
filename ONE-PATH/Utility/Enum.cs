using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ONE_PATH.Utility
{
    /// <summary>
    /// 代理类型
    /// </summary>
    public enum SoftList
    {
        /// <summary>
        /// 无 操作
        /// </summary>
        None = 0,

        /// <summary>
        /// Cmder环境变量
        /// </summary>
        Cmder = 1,

        /// <summary>
        /// java-jdk-jre环境变量
        /// </summary>
        Java = 2,

        /// <summary>
        /// Node环境变量
        /// </summary>
        Node = 3
    }
}