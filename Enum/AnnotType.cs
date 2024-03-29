using System;
using System.Collections.Generic;
using System.Text;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-27 16:09:36                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Enum
{
    /// <summary>
    /// 注释类型
    /// </summary>
    public enum AnnotType
    {
        /// <summary>
        /// 链接注释
        /// </summary>
        Link,
        /// <summary>
        /// 路径注释，一般为图形对象，比如矩形、多边形、贝塞尔曲线等
        /// </summary>
        Path,
        /// <summary>
        /// 高亮注释
        /// </summary>
        Highlight,
        /// <summary>
        /// 签章注释
        /// </summary>
        Stamp,
        /// <summary>
        /// 水印注释
        /// </summary>
        Watermark
    }
}