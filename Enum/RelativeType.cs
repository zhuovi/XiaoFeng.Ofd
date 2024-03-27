using System;
using System.Collections.Generic;
using System.Text;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-27 09:43:14                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Enum
{
    /// <summary>
    /// 相对类型
    /// </summary>
    public enum RelativeType
    {
        /// <summary>
        /// 相对于对象坐标系的原点
        /// </summary>
        Object = 0,
        /// <summary>
        /// 相对于页面坐标系统的原点
        /// </summary>
        Page = 1
    }
}