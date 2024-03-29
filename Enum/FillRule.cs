using System;
using System.Collections.Generic;
using System.Text;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-27 11:50:55                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Enum
{
    /// <summary>
    /// 填充规则，在路径内部的点作为填充时的有效区域，或作为裁剪区时的有效范围
    /// </summary>
    public enum FillRule
    {
        /// <summary>
        /// <para>非零绕数规则</para>
        /// <para>填充遵循如下原则:从所需判断的点处向任意方向无穷远处引一条射线, 同时引入一个初始值为0的计数, 射线每经过一条由左至右方向的线型时计数加1, 射线每经过一条由右至左方向的线型时则计数减1, 如果每条射线总计数均为0, 则判断该点在路径外部, 反之, 则该点在路径内部, 如图47所示。</para>
        /// </summary>
        [EnumName("NonZero")]
        NonZero = 0,
        /// <summary>
        /// <para>奇偶规则</para>
        /// <para>填充遵循如下原则:从所需判断的点处向任意方向无穷远处引一条射线, 同时引入一个初始值为0的计数, 射线每经过任意线型时计数加1, 如果每条射线总计数均为奇数, 则判断该点在路径内部, 反之, 则该点在路径外部, 如图48所</para>
        /// </summary>
        [EnumName("Event-Odd")]
        EventOdd = 1
    }
}