using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Attributes;
using XiaoFeng.Ofd.BaseType;
using XiaoFeng.Ofd.BasicStructure;
using XiaoFeng.Ofd.Enum;
using XiaoFeng.Xml;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-27 16:07:56                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Annots
{
    /// <summary>
    /// 注释信息
    /// </summary>
    public class Annot
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Annot()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 注释的标识
        /// </summary>
        [XmlAttribute]
        [Required]
        public STID ID { get; set; }
        /// <summary>
        /// 注释类型
        /// </summary>
        [XmlAttribute]
        [Required]
        [XmlConverter(typeof(StringEnumConverter))]
        public AnnotType Type { get; set; }
        /// <summary>
        /// 注释创建者
        /// </summary>
        [XmlAttribute]
        [Required]
        public string Creator { get; set; }
        /// <summary>
        /// 最近一次修改的时间
        /// </summary>
        [XmlAttribute]
        [Required]
        public DateTime? LastModDate { get; set; }
        /// <summary>
        /// 注释子类型
        /// </summary>
        [XmlAttribute]
        public string Subtype { get; set; }
        /// <summary>
        /// 表示该注释对象是否显示 默认值为 <see langword="true"/>
        /// </summary>
        [XmlAttribute]
        public bool? Visible { get; set; }
        /// <summary>
        /// 对象的 <see cref="Remark"/> 信息是否随页面一起打印，默认值为 <see langword="true"/>
        /// </summary>
        [XmlAttribute]
        public bool? Print { get; set; }
        /// <summary>
        /// 对象的 <see cref="Remark"/> 信息是否不随页面缩放而同步缩放，默认值为 <see langword="false"/>
        /// </summary>
        [XmlAttribute]
        public bool? NoZoom { get; set; }
        /// <summary>
        /// 对象有的 <see cref="Remark"/> 信息是否不随页面旋转而同步旋转，默认值为 <see langword="false"/>
        /// </summary>
        [XmlAttribute]
        public bool? NoRotate { get; set; }
        /// <summary>
        /// 对象的 <see cref="Remark"/> 信息是否不能被用户更改，默认值为 <see langword="true"/>
        /// </summary>
        [XmlAttribute]
        public bool? ReadOnly { get; set; }
        /// <summary>
        /// 注释说明内容
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 注释的静态呈现效果，使用页面块定义来描述
        /// </summary>
        public Appearance Appearance { get; set; }
        /// <summary>
        /// 注释参数集合
        /// </summary>
        public List<Parameter> Parameters { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}