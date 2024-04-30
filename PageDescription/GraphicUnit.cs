using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Attributes;
using XiaoFeng.Ofd.BaseType;
using XiaoFeng.Ofd.Enum;
using XiaoFeng.Xml;
using Action = XiaoFeng.Ofd.Actions.Action;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-27 11:00:31                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.PageDescription
{
    /// <summary>
    /// <para>图元对象</para>
    /// <para>图元对象是版式文档中页面上呈现内容的最基本单元，所有页面显示内容，包括文字、图形、图像等，都属于图元对象，或是图元对象的组合。</para>
    /// <para>详情说明 见图 <see langword="45"/> ，见表 <see langword="34"/> </para>
    /// </summary>
    public class GraphicUnit
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public GraphicUnit()
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
        /// 外接矩形，采用当前空间坐标系（页面坐标或其它窗口坐标)，当图元绘制超出此矩形区域时进行裁剪
        /// </summary>
        [XmlAttribute]
        [Required]
        public Box Boundary { get; set; }
        /// <summary>
        /// 图元对象的名字，默认值为空
        /// </summary>
        [XmlAttribute]
        public string Name { get; set; }
        /// <summary>
        /// 图元是否可见，默认值为true
        /// </summary>
        [XmlAttribute]
        public bool? Visible { get; set; }
        /// <summary>
        /// 对象空间内的图元变换矩阵
        /// </summary>
        [XmlAttribute]
        public STArray CTM { get; set; }
        /// <summary>
        /// 引用资源文件中的绘制参数标识
        /// </summary>
        [XmlAttribute]
        public STRefID DrawParam { get; set; }
        /// <summary>
        /// 绘制路径时使用的线宽，如果图元对象有 DrawParam 属性，则用此值覆盖 DrawParam 中对应的值
        /// </summary>
        [XmlAttribute]
        public double? LineWidth { get; set; }
        /// <summary>
        /// 见8.2绘制参数，如果图元对象有 DrawParam 属性，则用此值覆盖 DrawParam 中对应的值
        /// </summary>
        [XmlAttribute]
        public string Cap { get; set; }
        /// <summary>
        /// 见8.2绘制参数，如果图元对象有 DrawParam 属性，则用此值覆盖 DrawParam 中对应的值
        /// </summary>
        [XmlAttribute]
        [XmlConverter(typeof(StringEnumConverter))]
        public JoinType? Join { get; set; }
        /// <summary>
        /// Join 为 Miter时，MiterSize的截断值，如果图元对象有 DrawParam 属性，则用此值覆盖 DrawParam 中对应的值
        /// </summary>
        [XmlAttribute]
        public double? MiterLimit { get; set; }
        /// <summary>
        /// 见 8.2 绘制参数，如果图元对象有 DrawParam 属性，则用此值覆盖 DrawParam 中对应的值
        /// </summary>
        [XmlAttribute]
        public double? DashOffset { get; set; }
        /// <summary>
        /// 见 8.2 绘制参数，如果图元对象有 DrawParam 属性，则用此值覆盖 DrawParam 中对应的值
        /// </summary>
        [XmlAttribute]
        public STArray DashPattern { get; set; }
        /// <summary>
        /// 图元对象的透明度，取值[0,255],0表示全透明，255表示完全不透明，默认为0
        /// </summary>
        [XmlAttribute]
        public int? Alpha { get; set; }
        /// <summary>
        /// 图元动作，图元动作事件类型应为 CLICK（见表52事件类型）
        /// </summary>
        public List<Action> Actions { get; set; }
        /// <summary>
        /// 图元对象的裁剪区域序列，采用对象空间坐标系，当存在多个 <see cref="Clip"/> 对象时，最终裁剪区为所有 <see cref="Clip"/> 区域的交集
        /// </summary>
        public List<Clip> Clips { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}