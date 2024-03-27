using System;
using System.Collections.Generic;
using System.Text;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 21:13:33                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Enum
{
    /// <summary>
    /// 颜色空间类型
    /// </summary>
    public enum ColorSpaceType
    {
        /// <summary>
        /// 只包含一个通道来表明灰庆值 如 "#FF"、"255"
        /// </summary>
        GRAY = 0,
        /// <summary>
        /// 包含三个通道，依次是红、绿、蓝 如："#11 #22 #33"、"17 34 51"
        /// </summary>
        RGB = 1,
        /// <summary>
        /// 包含四个通道，依次是青、黄、品红、黑 如："#11 #22 #33 #44"、"17 34 51 68"
        /// </summary>
        CMYK = 2
    }
}