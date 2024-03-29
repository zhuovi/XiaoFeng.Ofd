using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.BaseType;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-27 14:16:15                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Fonts
{
    /// <summary>
    /// 文字定位
    /// </summary>
    public class TextCode
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public TextCode()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 第一个文字的字型原点在对象坐标系下的 <see cref="X"/> 坐标当 <see cref="X"/> 不出现, 则采用上一个 <see cref="TextCode"/> 的 <see cref="X"/> 值, 文字对象中的第一个 <see cref="TextCode"/> 的 <see cref="X"/> 属性必选
        /// </summary>
        [XmlAttribute]
        public double X { get; set; }
        /// <summary>
        /// 第一个文字的字型原点在对象坐标系下的 <see cref="Y"/> 坐标当 <see cref="Y"/> 不出现, 则采用上一个 <see cref="TextCode"/> 的 <see cref="Y"/> 值, 文字对象中的第一个 <see cref="TextCode"/> 的 <see cref="Y"/> 属性必选
        /// </summary>
        [XmlAttribute]
        public double Y { get; set; }
        /// <summary>
        /// double型数值队列,队列中的每个值代表后一个文字与前一个文字之间在 X 方向的偏移值，DeltaX 不出现时,表示文字的绘制点在 X 方向不做偏移
        /// </summary>
        [XmlAttribute]
        public STArray DeltaX { get; set; }
        /// <summary>
        /// double型数值队列,队列中的每个值代表后一个文字与前一个文字之间在 Y 方向的偏移值，DeltaY 不出现时,表示文字的绘制点在 Y 方向不做偏移
        /// </summary>
        [XmlAttribute]
        public STArray DeltaY { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}