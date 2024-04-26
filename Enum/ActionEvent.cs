using System;
using System.Collections.Generic;
using System.Text;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-27 11:43:02                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Enum
{
    /// <summary>
    /// 动作事件
    /// <para>详情说明 见表 <see langword="52"/> </para>
    /// </summary>
    public enum ActionEvent
    {
        /// <summary>
        /// 文档打开事件
        /// </summary>
        DO = 0,
        /// <summary>
        /// 页面打开事件
        /// </summary>
        PO = 1,
        /// <summary>
        /// 单击区域事件
        /// </summary>
        CLICK = 2
    }
}