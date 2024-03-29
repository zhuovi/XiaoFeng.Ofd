using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Attributes;
using XiaoFeng.Ofd.BaseType;
using XiaoFeng.Ofd.Enum;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 21:26:15                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.PageDescription
{
    /// <summary>
    /// 轴向渐变
    /// </summary>
    public class AxialShd
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public AxialShd()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 渐变绘制的方式，默认为Direct
        /// </summary>
        [XmlAttribute]
        public MapType MapType { get; set; }
        /// <summary>
        /// 轴线一个渐变区间的长度，当 MapType 的值不等于Direct时出现，默认值为轴线长度
        /// </summary>
        [XmlAttribute]
        public double MapUnit { get; set; }
        /// <summary>
        /// <para>轴线延长方向是否继续绘制渐变。可选值为0、1、2、3</para>
        /// <para><see langword="0"/> : 不向两侧继续绘制渐变</para>
        /// <para><see langword="1"/> : 在结束点至起始点延长线方向绘制渐变</para>
        /// <para><see langword="2"/> : 在起始点至结束点延长线方向绘制渐变</para>
        /// <para><see langword="3"/> : 向两侧延长线方向绘制渐变</para>
        /// </summary>
        [XmlAttribute]
        public int Extend { get; set; }
        /// <summary>
        /// 轴线的起始点
        /// </summary>
        [XmlAttribute]
        [Required]
        public Position StartPoint { get; set; }
        /// <summary>
        /// 轴线的结束点
        /// </summary>
        [XmlAttribute]
        [Required]
        public Position EndPoint { get; set; }
        /// <summary>
        /// 颜色段，至少出现两个
        /// </summary>
        public List<Segment> Segment { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}