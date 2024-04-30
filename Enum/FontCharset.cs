using System;
using System.Collections.Generic;
using System.Text;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-27 13:53:17                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Enum
{
    /// <summary>
    /// 字型编码
    /// </summary>
    public enum FontCharset
    {
        /// <summary>
        /// UNICODE
        /// </summary>
        unicode = 0,
        /// <summary>
        /// SYMBOL
        /// </summary>
        symbol = 1,
        /// <summary>
        /// PRC
        /// </summary>
        prc = 2,
        /// <summary>
        /// BIG5
        /// </summary>
        big5 = 3,
    }
}