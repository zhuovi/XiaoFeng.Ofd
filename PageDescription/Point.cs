using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Attributes;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-27 10:32:54                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.PageDescription
{
    /// <summary>
    /// 渐变控制点
    /// </summary>
    public class Point
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Point()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 控制点水平位置
        /// </summary>
        [XmlAttribute]
        [Required]
        public double X { get; set; }
        /// <summary>
        /// 控制点的垂直位置
        /// </summary>
        [XmlAttribute]
        [Required]
        public double Y { get; set; }
        /// <summary>
        /// 三角单元切换的方向标志
        /// </summary>
        [XmlAttribute]
        public int EdgeFlag { get; set; }
        /// <summary>
        /// 控制点对应的颜色，应用使用基本颜色
        /// </summary>
        [Required]
        public Color Color { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}