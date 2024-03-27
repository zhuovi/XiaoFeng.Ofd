using System;
using System.Collections.Generic;
using System.Text;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 19:35:06                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Enum
{
    /// <summary>
    /// 窗口模式
    /// </summary>
    public enum PageMode
    {
        /// <summary>
        /// 常规模式
        /// </summary>
        None = 0,
        /// <summary>
        /// 打开后全文显示
        /// </summary>
        FullScreen = 1,
        /// <summary>
        /// 同时呈现文档大纲
        /// </summary>
        UseOutlines = 2,
        /// <summary>
        /// 同时呈现缩略图
        /// </summary>
        UseThumbs = 3,
        /// <summary>
        /// 同时呈现语义结构
        /// </summary>
        UseCustomTags = 4,
        /// <summary>
        /// 同时呈现图层
        /// </summary>
        UseLayers = 5,
        /// <summary>
        /// 同时呈现附件
        /// </summary>
        UseAttatchs = 6,
        /// <summary>
        /// 同时呈现书签
        /// </summary>
        UserBookmarks = 7
    }
}