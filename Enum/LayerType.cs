using System;
using System.Collections.Generic;
using System.Text;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 18:55:26                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Enum
{
    /// <summary>
    /// 图层类型
    /// </summary>
    public enum LayerType
    {
        /// <summary>
        /// 正文层
        /// </summary>
        Body = 0,
        /// <summary>
        /// 前景层
        /// </summary>
        Foreground = 1,
        /// <summary>
        /// 背景层
        /// </summary>
        Background = 2
    }
}