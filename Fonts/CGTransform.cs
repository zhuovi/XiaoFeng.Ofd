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
*  Create Time : 2024-03-27 14:14:15                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Fonts
{
    /// <summary>
    /// 字型变换
    /// </summary>
    public class CGTransform
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public CGTransform()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// TextCode中字符编码的起始位置,从0开始
        /// </summary>
        [XmlAttribute]
        [Required]
        public int CodePosition { get; set; }
        /// <summary>
        /// 变换关系中字符的数量,该数值应大于或等于1,否则属于错误描述，默认为1
        /// </summary>
        [XmlAttribute]
        public int CodeCount { get; set; }
        /// <summary>
        /// 变换关系中字形索引的个数,该数值应大于或等于1,否则属于错误描述, 默认为1
        /// </summary>
        [XmlAttribute]
        public int GlyphCount { get; set; }
        /// <summary>
        /// 变换后的字形索引列表
        /// </summary>
        [Required]
        public STArray Glyphs { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}