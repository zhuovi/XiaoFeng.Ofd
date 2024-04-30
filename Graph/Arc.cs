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
*  Create Time : 2024-03-27 12:53:05                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Graph
{
    /// <summary>
    /// 圆弧
    /// <para>详情说明 见图 <see langword="56"/> ，见表 <see langword="42"/> </para>
    /// </summary>
    public class Arc:IGraph
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Arc()
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
        /// 圆弧的结束点，下个路径的起始点，不能与当前的绘制起始点为同一位置
        /// </summary>
        [XmlAttribute]
        [Required]
        public Position EndPoint { get; set; }
        /// <summary>
        /// <para>形如[200 100]的数组,2个正浮点数值依次对应椭圆的长、短轴长度,较大的一个为长轴</para>
        ///<para>[异常处理] 如果数组长度超过2, 则只取前两个数值</para>
        ///<para>[异常处理]如果数组长度为1,则认为这是一个圆,该数值为圆半径必选</para>
        ///<para>[异常处理]如果数组前两个数值中有一个为0,或者数组为空,则圆弧退化为一条从当前点到EndPoint的线段</para>
        ///<para>[异常处理]如果数组数值为负值,则取其绝对值</para>
        /// </summary>
        [XmlAttribute]
        [Required]
        public STArray EllipseSize { get; set; }
        /// <summary>
        /// <para>表示按EllipseSize绘制的椭圆在当前坐标系下旋转的角度,正值为顺时针, 负值为逆时针</para>
        /// <para>[异常处理] 如果角度大于360°, 则以360取模</para>
        /// </summary>
        [XmlAttribute]
        [Required]
        public double RotationAngle { get; set; }
        /// <summary>
        /// 是否是大圆弧true 表示此线型对应的为度数大于180°的弧，false表示对应度数小于 180°的弧对于一个给定长、短轴的椭圆以及起始点和结束点,有一大一小两条圆弧, 如果所描述线型恰好为180°的弧,则此属性的值不被参考，可由SweepDirection属性确定圆弧的形状
        /// </summary>
        [XmlAttribute]
        [Required]
        public bool LargeArc { get; set; }
        /// <summary>
        /// 弧线方向是否为顺时针true 表示由圆弧起始点到结束点是顺时针旋转,false表示由圆弧起始点到结束点是逆时针旋转对于经过坐标系上指定两点，给定旋转角度和长短轴长度的椭圆，满足条件的可能有2个,对应圆弧有4条,通过LargeArc属性可以排除2条, 由此属性从余下的2条圆弧中确定一条
        /// </summary>
        [XmlAttribute]
        [Required]
        public bool SweepDirection { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}