using System;
using System.Collections.Generic;
using System.Text;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 20:42:28                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Enum
{
    /// <summary>
    /// 线条连接样式
    /// </summary>
    public enum JoinType
    {
        /// <summary>
        /// 斜接
        /// </summary>
        Miter = 0,
        /// <summary>
        /// 圆形
        /// </summary>
        Round = 1,
        /// <summary>
        /// 斜面
        /// </summary>
        Bevel = 2
    }
}