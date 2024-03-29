using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Attributes;
using XiaoFeng.Ofd.Enum;
using XiaoFeng.Ofd.Internal;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 15:12:12                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.BasicStructure
{
    /// <summary>
    /// <para>入口文件模型 OFD.xml</para>
    /// <para>图 <see langword="3"/> ，表 <see langword="3"/> </para>
    /// </summary>
    public class OFD
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public OFD()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 文件格式的版本号,取值为"1.0"
        /// </summary>
        [XmlAttribute]
        [Required]
        public string Version { get; set; } = "1.0";
        /// <summary>
        /// 文件格式子集类型
        /// </summary>
        [XmlAttribute]
        [Required]
        public DocumentType DocType { get; set; } = DocumentType.OFD;
        /// <summary>
        /// 文件对象入口，可以存在多个，以便在一个文档中包含多个版式文档
        /// </summary>
        [Required]
        public List<DocBody> DocBody { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}