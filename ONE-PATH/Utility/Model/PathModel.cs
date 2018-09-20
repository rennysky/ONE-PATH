using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ONE_PATH.Utility.Model
{
    class PathModel
    {
        public enum ServerPath
        {
            /// <summary>
            /// PATH路径
            /// </summary>
            PATH = 0,

            /// <summary>
            /// TEMP缓存
            /// </summary>
            TEMP = 1,

            /// <summary>
            /// TMP缓存
            /// </summary>
            TMP = 2
        }
    }
}