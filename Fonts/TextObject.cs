using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Attributes;
using XiaoFeng.Ofd.BaseType;
using XiaoFeng.Ofd.BasicStructure;
using XiaoFeng.Ofd.Enum;
using XiaoFeng.Ofd.PageDescription;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-27 14:01:22                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Fonts
{
    /// <summary>
    /// 文字对象
    /// <para>详情说明 见图 <see langword="59"/> ，见表 <see langword="45"/> </para>
    /// </summary>
    public class TextObject : GraphicUnit, IPageBlock
    {
        #region 构造器
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        public TextObject()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 引用资源文件中定义的字型的标识
        /// </summary>
        [XmlAttribute("Font")]
        [Required]
        public STRefID FontID { get; set; }
        /// <summary>
        /// 字号，单位为毫米
        /// </summary>
        [XmlAttribute]
        [Required]
        public double Size { get; set; }
        /// <summary>
        /// 是否勾边，默认值为 <see langword="false"/>
        /// </summary>
        [XmlAttribute]
        public bool? Stroke { get; set; }
        /// <summary>
        /// 是否填充，默认值为 <see langword="true"/>
        /// </summary>
        [XmlAttribute]
        public bool? Fill { get; set; }
        /// <summary>
        /// 字型在水平方向的放缩比，默认值为 1.0 ，例如：当 <see cref="HScale"/> 值为 <see langword="0.5"/> 时表示 实际显示的字宽为原来字宽的一半
        /// </summary>
        [XmlAttribute]
        public double? HScale { get; set; }
        /// <summary>
        /// 阅读方向，指定了文字排列的方向，描述见 11.3 文字定位 ，默认值为 <see langword="0"/>
        /// </summary>
        [XmlAttribute]
        public Direction? ReadDirection { get; set; }
        /// <summary>
        /// 字符方向，指定了文字放置的方式，具体内容见 11.3 文字定位 ，默认值为 <see langword="0"/>
        /// </summary>
        [XmlAttribute]
        public Direction? CharDirection { get; set; }
        /// <summary>
        /// 文字对象的粗细值；可选取值为 100，200，300，400，500，600，700，800，900，默认值为400
        /// </summary>
        [XmlAttribute]
        public int? Weight { get; set; }
        /// <summary>
        /// 是否是斜体样式，默认值为 <see langword="false"/>
        /// </summary>
        [XmlAttribute]
        public bool? Italic { get; set; }
        /// <summary>
        /// 填充颜色，默认为黑色
        /// </summary>
        public Color FillColor { get; set; }
        /// <summary>
        /// 勾边颜色，默认为透明色
        /// </summary>
        public Color StrokeColor { get; set; }
        /// <summary>
        /// 指定字符编码到字符索引之前的变换关系，描述见 <see langword="11.4"/> 字符变换
        /// </summary>
        [XmlArrayItem("CGTransform")]
        public List<CGTransform> CGTransform { get; set; }
        /// <summary>
        /// 文字内容
        /// </summary>
        [XmlArrayItem("TextCode")]
        public List<TextCode> TextCode { get; set; }
        #endregion

        #region 方法
        /// <summary>
        /// 添加文字内容
        /// </summary>
        /// <param name="textCode">文字内容</param>
        public void AddText(TextCode textCode)
        {
            if (this.TextCode == null) this.TextCode = new List<TextCode>();
            this.TextCode.Add(textCode);
        }
        /// <summary>
        /// 添加文字内容
        /// </summary>
        /// <param name="text">文字内容</param>
        /// <param name="x">X坐标</param>
        /// <param name="y">Y坐标</param>
        public void AddText(string text, double? x = null, double? y = null)
        {
            this.AddText(new TextCode(text, x, y));
        }
        /// <summary>
        /// 添加字型变换
        /// </summary>
        /// <param name="transform">字型变换</param>
        public void AddCGTransform(CGTransform transform)
        {
            if (this.CGTransform == null) this.CGTransform = new List<CGTransform>();
            this.CGTransform.Add(transform);
        }
        ///<inheritdoc/>
        public override string ToString()
        {
            if (this.TextCode == null || this.TextCode.Count == 0) return string.Empty;
            return $"{this.TextCode.Select(a => a.Value).Join(" ")}";
        }
        #endregion
    }
}