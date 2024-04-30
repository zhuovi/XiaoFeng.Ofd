using System;
using System.Collections.Generic;
using System.Text;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-04-29 18:32:54                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Enum
{
    /// <summary>
    /// 方向（文字排列方向或阅读方向） 
    /// <para>详情说明 见表 <see langword="47"/> </para>
    /// </summary>
    public enum Direction
    {
        /// <summary>
        /// 0°
        /// </summary>
        A = 0,
        /// <summary>
        /// 90°
        /// </summary>
        B = 90,
        /// <summary>
        /// 180°
        /// </summary>
        C = 180,
        /// <summary>
        /// 270°
        /// </summary>
        D = 270
    }
}