using System;
using System.Collections.Generic;
using System.Text;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 15:14:04                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Enum
{
    /// <summary>
    /// 文件格式子集类型
    /// </summary>
    public enum DocumentType
    {
        /// <summary>
        /// 符合当前《GB/T 33190-2016 电子文件存储与交换格式版式文档》标准
        /// </summary>
        OFD = 0,
        /// <summary>
        /// 符合OFD存档规范
        /// </summary>
        OFD_A = 1
    }
}