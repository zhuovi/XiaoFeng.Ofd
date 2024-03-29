using System;
using System.Collections.Generic;
using System.Text;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-27 14:45:13                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Enum
{
    /// <summary>
    /// 目标类型
    /// </summary>
    public enum DestType
    {
        /// <summary>
        /// 目标区域由左上角位置(Left,Top)以及页面绽放比例(Zoom)确定;
        /// </summary>
        XYZ,
        /// <summary>
        /// 适合整个窗口区域
        /// </summary>
        Fit,
        /// <summary>
        /// 适合窗口宽度，目标区域仅由 Top 确定;
        /// </summary>
        FitH,
        /// <summary>
        /// 适合窗口高度，目标区域仅由 Left 确定;
        /// </summary>
        FitV,
        /// <summary>
        /// 适合窗口内的目标区域，目标不区域为(Left、Top、Right、Bottom)所确定的矩形区域
        /// </summary>
        FitR
    }
}