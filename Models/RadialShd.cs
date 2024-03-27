using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Enum;
using XiaoFeng.Ofd.Internal;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 21:26:24                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Models
{
    /// <summary>
    /// 径向渐变
    /// </summary>
    public class RadialShd
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public RadialShd()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 渐变绘制的方式，默认值为Direct
        /// </summary>
        [XmlAttribute]
        public MapType MapType { get; set; } = MapType.Direct;
        /// <summary>
        /// 中心点连线上一个渐变区间所绘制的长度，当 MapType 的值不为Direct 时出现，默认值为中心点连线长度
        /// </summary>
        [XmlAttribute]
        public double MapUnit { get; set; }
        /// <summary>
        /// 两个椭圆的离心率，即椭圆焦距与长轴的比值，取值范围是[0,1.0)，默认值为0，在这种情况下椭圆退化为圆
        /// </summary>
        [XmlAttribute]
        public double Eccentricity { get; set; }
        /// <summary>
        /// 两个椭圆的倾斜角度，椭圆长轴与x轴正向的夹角，单位为度，默认值为0
        /// </summary>
        [XmlAttribute]
        public double Angle { get; set; }
        /// <summary>
        /// 起始椭圆的中心点
        /// </summary>
        [XmlAttribute]
        public Position StartPoint {  get; set; }
        /// <summary>
        /// 结束椭圆的中心点
        /// </summary>
        [XmlAttribute]
        public Position Endoint { get; set; }
        /// <summary>
        /// 超始椭圆的长半轴，默认值为0
        /// </summary>
        [XmlAttribute]
        public double StartRadius { get; set; }
        /// <summary>
        /// 结束椭圆的长半轴
        /// </summary>
        [XmlAttribute]
        public double EndRadius { get; set; }
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
        /// 颜色段，至少出现两个
        /// </summary>
        public List<Segment> Segment { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}