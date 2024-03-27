using System;
using System.Collections.Generic;
using System.Text;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 19:40:26                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Enum
{
    /// <summary>
    /// 标题栏显示模式
    /// </summary>
    public enum TabDisplay
    {
        /// <summary>
        /// 文件名称
        /// </summary>
        FileName = 0,
        /// <summary>
        /// 呈现元数据中的Title属性
        /// </summary>
        DocTitle = 1
    }
}