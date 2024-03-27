using System;
using System.Collections.Generic;
using System.Text;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 19:42:15                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Enum
{
    /// <summary>
    /// 缩放模式
    /// </summary>
    public enum ZoomMode
    {
        /// <summary>
        /// 默认缩放
        /// </summary>
        Default = 0,
        /// <summary>
        /// 适合高度
        /// </summary>
        FitHeight = 1,
        /// <summary>
        /// 适合宽度
        /// </summary>
        FitWidth = 2,
        /// <summary>
        /// 适合区域
        /// </summary>
        FitRect = 3
    }
}