using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Attributes;
using XiaoFeng.Ofd.BaseType;
using XiaoFeng.Ofd.Enum;
using XiaoFeng.Xml;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-27 13:50:47                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Fonts
{
    /// <summary>
    /// 字型
    /// <para>详情说明 见图 <see langword="58"/> ，见表 <see langword="44"/> </para>
    /// </summary>
    public class Font
    {
        #region 构造器
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        public Font() { }
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="id">字型ID</param> 
        /// <param name="name">字型名</param>
        public Font(STID id, string name)
        {
            this.ID = id;
            if (name.IsNullOrEmpty()) return;
            this.FontName = name;
            this.FamilyName = name;
        }
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="id">字型ID</param> 
        /// <param name="name">字型名</param>
        /// <param name="familyName">字形族名</param>
        public Font(STID id, string name, string familyName)
        {
            this.ID = id;
            if (name.IsNullOrEmpty() && familyName.IsNullOrEmpty()) return;
            if (name.IsNullOrEmpty())
            {
                this.FontName = familyName;
                this.FamilyName = familyName;
            }
            else
            {
                this.FontName = name;
                this.FamilyName = familyName.IsNullOrEmpty() ? name : familyName;
            }
        }
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="id">字型ID</param> 
        /// <param name="fontName">字型名</param>
        /// <param name="familyName">字形族名</param>
        /// <param name="serif">是否是带衬线字型</param>
        /// <param name="bold">是否是粗体字型</param>
        /// <param name="italic">是否是斜体字型</param>
        /// <param name="fixedWidth">是否是等宽字型</param>
        /// <param name="fontFile">指向内嵌字形文件</param>
        /// <param name="charset">字型适用的字符分类</param>
        public Font(STID id, string fontName, string familyName, bool serif, bool bold, bool italic, bool fixedWidth, Location fontFile, FontCharset charset = FontCharset.unicode) : this(id, fontName, familyName)
        {
            Charset = charset;
            Serif = serif;
            Bold = bold;
            Italic = italic;
            FixedWidth = fixedWidth;
            FontFile = fontFile;
        }
        #endregion

        #region 属性
        /// <summary>
        /// 字型ID
        /// </summary>
        [XmlAttribute]
        public STID ID { get; set; }
        /// <summary>
        /// 字型名
        /// </summary>
        [XmlAttribute]
        [Required]
        public string FontName { get; set; }
        /// <summary>
        /// 字形族名，用于匹配替代字型
        /// </summary>
        [XmlAttribute]
        public string FamilyName { get; set; }
        /// <summary>
        /// 字型适用的字符分类，用于匹配替代字型，默认为unicode
        /// </summary>
        [XmlAttribute]
        [XmlConverter(typeof(StringEnumConverter))]
        public FontCharset? Charset { get; set; }
        /// <summary>
        /// 是否是带衬线字型，用于匹配替代代字型，默认值是false
        /// </summary>
        [XmlAttribute]
        public bool? Serif { get; set; }
        /// <summary>
        /// 是否是粗体字型，用于匹配替代字型，默认值是false
        /// </summary>
        [XmlAttribute]
        public bool? Bold { get; set; }
        /// <summary>
        /// 是否是斜体字型，用于匹配替代字型，默认值为false
        /// </summary>
        [XmlAttribute]
        public bool? Italic { get; set; }
        /// <summary>
        /// 是否是等宽字型，用于匹配替代字形，默认值为false
        /// </summary>
        [XmlAttribute]
        public bool? FixedWidth { get; set; }
        /// <summary>
        /// 指向内嵌字形文件，嵌入字形文件应使用 OpenType 格式
        /// </summary>
        public Location FontFile { get; set; }
        #endregion

        #region 方法
        /// <summary>
        /// 黑体
        /// </summary>
        public static Font SimHei(uint id) => new Font(id, "黑体", "黑体");
        /// <summary>
        /// 微软雅黑
        /// </summary>
        public static Font MicrosoftYahei(uint id) => new Font(id, "微软雅黑", "微软雅黑");
        /// <summary>
        /// 仿宋
        /// </summary>
        public static Font FangSong(uint id) => new Font(id, "仿宋", "仿宋");
        /// <summary>
        /// 宋体
        /// </summary>
        public static Font SimSun(uint id) => new Font(id, "宋体", "宋体");
        /// <summary>
        /// 楷体
        /// </summary>
        public static Font KaiTi(uint id) => new Font(id, "楷体", "Simsun");
        /// <summary>
        /// 希腊字体
        /// </summary>
        public static Font Symbol => new Font("Symbol", "Symbol");
        /// <summary>
        /// 无衬线字体
        /// </summary>
        public static Font Arial => new Font("Arial", "Arial");
        /// <summary>
        /// 两个字型对象是否相等
        /// </summary>
        /// <param name="left">左边字型对象</param>
        /// <param name="right">右边字型对象</param>
        /// <returns></returns>
        public static bool operator ==(Font left,Font right)
        {
            return left.ToString() == right.ToString();
        }
        /// <summary>
        /// 两个字型对象是否不相等
        /// </summary>
        /// <param name="left">左边字型对象</param>
        /// <param name="right">右边字型对象</param>
        /// <returns></returns>
        public static bool operator !=(Font left, Font right) => !(left == right);
        ///<inheritdoc/>
        public override string ToString()
        {
            return $"{this.FamilyName}-{this.FontName}";
        }
        #endregion
    }
}