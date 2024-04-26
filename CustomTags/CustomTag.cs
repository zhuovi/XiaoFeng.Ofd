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
*  Create Time : 2024-03-27 16:24:06                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.CustomTags
{
    /// <summary>
    /// <para>自定义标引</para>
    /// <para>详情说明 见图 <see langword="82"/> ，见表 <see langword="63"/> </para>
    /// </summary>
    public class CustomTag
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public CustomTag()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 自定义标引内容节点适用的类型标识
        /// </summary>
        [XmlAttribute]
        [Required]
        public string TypeID { get; set; }
        /// <summary>
        /// 指向自定义标引内容节点适用的 Schema 文件
        /// </summary>
        public Location SchemaLoc { get; set; }
        /// <summary>
        /// 指向自定义标引文件，该类文件中通过“非接触方式”引用版式内容流中的图元和相关信息
        /// </summary>
        [Required]
        public Location FileLoc { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}