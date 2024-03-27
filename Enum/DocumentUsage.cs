using System;
using System.Collections.Generic;
using System.Text;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 14:51:53                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Enum
{
    /// <summary>
    /// 文档分类
    /// </summary>
    public enum DocumentUsage
    {
        /// <summary>
        /// 普通文档
        /// </summary>
        Normal = 0,
        /// <summary>
        /// 电子书
        /// </summary>
        EBook = 1,
        /// <summary>
        /// 电子报纸
        /// </summary>
        ENewsPaper = 3,
        /// <summary>
        /// 电子期刊杂志
        /// </summary>
        EMagzine = 4
    }
}