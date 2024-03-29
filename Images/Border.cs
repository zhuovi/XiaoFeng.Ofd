using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.BaseType;
using XiaoFeng.Ofd.PageDescription;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-27 13:43:55                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Images
{
    /// <summary>
    /// 边框
    /// </summary>
    public class Border
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Border()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 边框线宽，如果为0则表示 边框不进行绘制，默认值为0.353mm
        /// </summary>
        [XmlAttribute]
        public double LineWidth { get; set; }
        /// <summary>
        /// 边框水平角半径，默认值为0
        /// </summary>
        [XmlAttribute]
        public double HorizonalCornerRadius { get; set; }
        /// <summary>
        /// 边框垂直角半径，默认值为0
        /// </summary>
        [XmlAttribute]
        public double VerticalCornerRadius { get; set; }
        /// <summary>
        /// 边框虚线重复样式开始的位置，边框的起始点位置为左上角，绕行方向为顺时针，默认值为0
        /// </summary>
        [XmlAttribute]
        public double DashOffset { get; set; }
        /// <summary>
        /// 边框虚线重复样式，边框的起始点位置为左上角，绕行方向为顺时针，默认值为0
        /// </summary>
        [XmlAttribute]
        public STArray DashPattern { get; set; }
        /// <summary>
        /// 边框颜色，有关边框颜色描述见8.3.2基本颜色，默认为黑色
        /// </summary>
        public Color BorderColor { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}