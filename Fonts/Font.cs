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
*  Create Time : 2024-03-27 13:50:47                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Fonts
{
    /// <summary>
    /// 字型
    /// </summary>
    public class Font
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Font()
        {

        }
        #endregion

        #region 属性
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
        public FontCharset Charset { get; set; } = FontCharset.unicode;
        /// <summary>
        /// 是否是带衬线字型，用于匹配替代代字型，默认值是false
        /// </summary>
        [XmlAttribute]
        public bool Serif { get; set; }
        /// <summary>
        /// 是否是粗体字型，用于匹配替代字型，默认值是false
        /// </summary>
        [XmlAttribute]
        public bool Bold { get; set; }
        /// <summary>
        /// 是否是斜体字型，用于匹配替代字型，默认值为false
        /// </summary>
        [XmlAttribute]
        public bool Italic { get; set; }
        /// <summary>
        /// 是否是等宽字型，用于匹配替代字形，默认值为false
        /// </summary>
        [XmlAttribute]
        public bool FixedWidth { get; set; }
        /// <summary>
        /// 指向内嵌字形文件，嵌入字形文件应使用 OpenType 格式
        /// </summary>
        public Location FontFile { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}