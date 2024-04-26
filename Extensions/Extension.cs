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
*  Create Time : 2024-03-27 16:28:35                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Extensions
{
    /// <summary>
    /// <para>扩展信息</para>
    /// <para>详情说明 见图 <see langword="84"/> ，见表 <see langword="65"/> </para>
    /// </summary>
    public class Extension
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Extension()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 用于生成或解释该自定义对象数据的扩展应用程序名称
        /// </summary>
        [XmlAttribute]
        [Required]
        public string AppName { get; set; }
        /// <summary>
        /// 形成此扩展信息的软件厂商标识
        /// </summary>
        [XmlAttribute]
        public string Company { get; set; }
        /// <summary>
        /// 形成此扩展信息的软件版本
        /// </summary>
        [XmlAttribute]
        public string AppVersion { get; set; }
        /// <summary>
        /// 形成此扩展信息的日期时间
        /// </summary>
        [XmlAttribute]
        public DateTime Date { get; set; }
        /// <summary>
        /// 引用扩展项针对的文档项目的标识
        /// </summary>
        [XmlAttribute]
        [Required]
        public STRefID RefId { get; set; }
        /// <summary>
        /// 扩展属性
        /// </summary>
        [XmlArrayItem]
        public List<Property> Properties { get; set; }
        /// <summary>
        /// 扩展复杂属性，使用 xs:anyType,用于复杂的扩展
        /// </summary>
        [XmlArrayItem("Data")]
        public List<string> Data { get; set; }
        /// <summary>
        /// 扩展数据文件所在位置，用于扩展大量信息
        /// </summary>
        [XmlArrayItem("ExtendData")]
        public List<Location> ExtendData { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}