using System;
using System.Collections.Generic;
using System.Text;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-05-15 15:57:57                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Enum
{
    /// <summary>
    /// 混合模式
    /// </summary>
    public enum BlendMode
    {
        /// <summary>
        /// 兼容模式
        /// </summary>
        Compatible = 0,
        /// <summary>
        /// 相乘模式
        /// </summary>
        Multiply = 1,
        /// <summary>
        /// 屏幕模式
        /// </summary>
        Screen = 2,
        /// <summary>
        /// 叠加模式
        /// </summary>
        Overlay = 3,
        /// <summary>
        /// 变暗模式
        /// </summary>
        Darken = 4,
        /// <summary>
        /// 减轻模式
        /// </summary>
        Lighten = 5,
        /// <summary>
        /// 颜色躲避
        /// </summary>
        ColorDodge = 6,
        /// <summary>
        /// 颜色烧伤 
        /// </summary>
        ColorBurn = 7,
        /// <summary>
        /// 强光模式
        /// </summary>
        HardLight = 8,
        /// <summary>
        /// 柔光模式
        /// </summary>
        SoftLight = 9,
        /// <summary>
        /// 差异模式
        /// </summary>
        Difference = 10,
        /// <summary>
        /// 排除模式
        /// </summary>
        Exclusion = 11,
        /// <summary>
        /// 色调模式
        /// </summary>
        Hue = 12,
        /// <summary>
        /// 饱和模式
        /// </summary>
        Saturation = 13,
        /// <summary>
        /// 颜色模式
        /// </summary>
        Color = 14,
        /// <summary>
        /// 光度模式
        /// </summary>
        Luminosity = 15
    }
}