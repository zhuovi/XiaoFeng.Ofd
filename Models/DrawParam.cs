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
*  Create Time : 2024-03-26 20:41:14                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Models
{
    /// <summary>
    /// 绘制参数
    /// </summary>
    public class DrawParam
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public DrawParam()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 基础绘制参数，引用资源文件中的绘制参数的标识
        /// </summary>
        [XmlAttribute]
        public uint Relative { get; set; }
        /// <summary>
        /// 线条连接样式，指定了两个线的结合时采用的样式
        /// </summary>
        [XmlAttribute]
        public JoinType Join { get; set; } = JoinType.Miter;
        /// <summary>
        /// 线宽,非负浮点数,指定了路径绘制时线的宽度。由于某些设备不 能输出一个像素宽度的线,因此强制规定当线宽大于0时,无论多小都最少要绘制两个像素的宽度; 当线宽为0时,绘制一个像素的宽度。由于线宽0的定义与设备相关,所以不推荐使用线宽0。默认值为0.353mm
        /// </summary>
        [XmlAttribute]
        public double LineWidth { get; set; } = 0.353;
        /// <summary>
        /// 线条虚线样式开始的位置,默认值为0。当 DashPattern不出现时，该参数无效
        /// </summary>
        [XmlAttribute]
        public double DashOffset { get; set; }
        /// <summary>
        /// 线条虚线的重复样式,数组中共含两个值,第一个值代表虚线线段的长度,第二个值代表虚线间隔的长度。默认值为空。线条虚线样式的控制效果见表23
        /// </summary>
        [XmlAttribute]
        public STArray DashPattern { get; set; }
        /// <summary>
        /// 线端点样式,枚举值,指定了一条线的端点样式
        /// </summary>
        [XmlAttribute]
        public CapStyle Cap { get; set; } = CapStyle.Butt;
        /// <summary>
        /// oin 为 Miter时小角度结合点长度的截断值,默认值为3.528。当Join 不等于Miter时该参数无效
        /// </summary>
        [XmlAttribute]
        public double MiterLimit { get; set; }
        /// <summary>
        /// 填充颜色，用以填充路径形成的区域以及文字轮廓内的区域，默认值为透明色。关于颜色的描述见8.3
        /// </summary>
        public Color FillColor { get; set; }
        /// <summary>
        /// 勾边颜色，指定路径绘制的颜色以及文字轮廓的颜色，默认值为黑色。颜色的描述见8.3
        /// </summary>
        public Color StrokeColor { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}