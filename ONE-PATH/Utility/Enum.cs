using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ONE_PATH.Utility
{
    /// <summary>
    /// 代理类型
    /// </summary>
    public enum ProxyType
    {
        /// <summary>
        /// 无代理
        /// </summary>
        NONE = 0,
        /// <summary>
        /// HTTP代理
        /// </summary>
        HTTP = 1,
        /// <summary>
        /// SOCKS5代理
        /// </summary>
        SOCKS5 = 2
    }
}
