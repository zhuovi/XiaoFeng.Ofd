using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.BaseType;
using XiaoFeng.Xml;

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
    /// <para>文字定位</para>
    /// <para>文字对象使用严格的文字定位信息进行定位</para>
    /// <para>详情说明 见图 <see langword="61"/> ，见表 <see langword="46"/> </para>
    /// </summary>
    public class TextCode
    {
        #region 构造器
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        public TextCode() { }
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="text">文本内容</param>
        /// <param name="x">X坐标</param>
        /// <param name="y">Y坐标</param>
        public TextCode(string text, double? x = null, double? y = null)
        {
            this.Value = text;
            if (x.HasValue) this.X = x.Value;
            if (y.HasValue) this.Y = y.Value;
        }
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="text">文本内容</param>
        /// <param name="x">X坐标</param>
        /// <param name="y">Y坐标</param>
        /// <param name="deltaX">后一个文字与前一个文字之间在 X 方向的偏移值</param>
        /// <param name="deltaY">后一个文字与前一个文字之间在 Y 方向的偏移值</param>
        public TextCode(string text, double x, double y, STArray deltaX = null, STArray deltaY = null)
        {
            Value = text;
            X = x;
            Y = y;
            DeltaX = deltaX;
            DeltaY = deltaY;
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
        /// <summary>
        /// 文字字符串
        /// </summary>
        [XmlText]        
        public string Value { get; set; }
        #endregion

        #region 方法
        ///<inheritdoc/>
        public override string ToString()
        {
            return $"{this.Value}";
        }
        #endregion
    }
}