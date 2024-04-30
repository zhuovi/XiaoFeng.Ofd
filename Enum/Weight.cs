using System;
using System.Collections.Generic;
using System.Text;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-04-30 13:52:28                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Enum
{
    /// <summary>
    /// 文宇对象的粗细值；可选取值为100,200,300,4D0,5DD,600,700,800,900   默认值为400
    /// <para>详情说明 见表 <see langword="45"/> </para>
    /// </summary>
    public enum Weight
    {
        /// <summary>
        /// 100
        /// </summary>
        W100 = 100,
        /// <summary>
        /// 200
        /// </summary>
        W200 = 200,
        /// <summary>
        /// 300
        /// </summary>
        W300 = 300,
        /// <summary>
        /// 400
        /// </summary>
        W400 = 400,
        /// <summary>
        /// 500
        /// </summary>
        W500 = 500,
        /// <summary>
        /// 600
        /// </summary>
        W600 = 600,
        /// <summary>
        /// 700
        /// </summary>
        W700 = 700,
        /// <summary>
        /// 800
        /// </summary>
        W800 = 800, 
        /// <summary>
        /// 900
        /// </summary>
        W900 = 900
    }
}