using System;
using System.Collections.Generic;
using System.Text;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-27 16:01:01                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Enum
{
    /// <summary>
    /// 放映参数
    /// <para>详情说明 见表 <see langword="59"/> </para>
    /// </summary>
    public enum OperatorType
    {
        /// <summary>
        /// 播放
        /// </summary>
        Play,
        /// <summary>
        /// 停止
        /// </summary>
        Stop,
        /// <summary>
        /// 暂停
        /// </summary>
        Pause,
        /// <summary>
        /// 继续
        /// </summary>
        Resume
    }
}