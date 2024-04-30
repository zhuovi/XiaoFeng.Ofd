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
*  Create Time : 2024-03-27 12:42:05                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Graph
{
    /// <summary>
    /// 二次贝塞尔曲线
    /// <para>详情说明 见图 <see langword="52"/> ，见表 <see langword="40"/> </para>
    /// </summary>
    public class QuadraticBezier:IGraph
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public QuadraticBezier()
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
        /// 二次贝塞尔曲线的控制点
        /// </summary>
        [XmlAttribute]
        [Required]
        public Position Point1 { get; set; }
        /// <summary>
        /// 二次贝塞尔曲线的结束点，下一路径的起始点
        /// </summary>
        [XmlAttribute]
        [Required]
        public Position Point2 { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}