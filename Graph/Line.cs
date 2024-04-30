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
*  Create Time : 2024-03-27 12:41:49                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Graph
{
    /// <summary>
    /// <para>线段</para>
    /// <para></para>
    /// <para>详情说明 见图 <see langword="51"/> ，见表 <see langword="39"/> </para>
    /// </summary>
    public class Line:IGraph
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Line()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// ID
        /// </summary>
        [XmlAttribute]
        public STID ID { get; set; }
        /// <summary>
        /// 线段的结束点
        /// </summary>
        [XmlAttribute]
        [Required]
        public Position Point1 { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}