using System;
using System.Collections.Generic;
using System.Text;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 19:38:27                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Enum
{
    /// <summary>
    /// 页面布局模式
    /// </summary>
    public enum PageLayout
    {
        /// <summary>
        /// 单页模式
        /// </summary>
        OnePage = 0,
        /// <summary>
        /// 单列模式
        /// </summary>
        OneColumn = 1,
        /// <summary>
        /// 对开模式
        /// </summary>
        TwoPageL= 2,
        /// <summary>
        /// 对开连续模式
        /// </summary>
        TwoColumnL= 3,
        /// <summary>
        /// 对开靠右模式
        /// </summary>
        TwoPageR= 4,
        /// <summary>
        /// 对开连续靠右模式
        /// </summary>
        TwoColumnR= 5
    }
}