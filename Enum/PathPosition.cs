using System;
using System.Collections.Generic;
using System.Text;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-04-30 12:06:06                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Enum
{
    /// <summary>
    /// 定位方式
    /// </summary>
    public enum PathPosition
    {
        /// <summary>
        /// 静态定位
        /// </summary>
        Staic = 0,
        /// <summary>
        /// 相对定位
        /// </summary>
        Relative = 1,
        /// <summary>
        /// 绝对定位
        /// </summary>
        Absolute = 2
    }
}