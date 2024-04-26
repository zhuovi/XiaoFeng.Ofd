using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Attributes;
using XiaoFeng.Ofd.BaseType;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-27 12:41:39                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Graph
{
    /// <summary>
    /// <para>移动</para>
    /// <para>移动节点用于表示移动到新的绘制点指令</para>
    /// <para>详情说明 见图 <see langword="50"/> ，见表 <see langword="38"/> </para>
    /// </summary>
    public class Move
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Move()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 移动后新的当前绘制点
        /// </summary>
        [XmlAttribute]
        [Required]
        public Position Point1 { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}