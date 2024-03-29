using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Attributes;
using XiaoFeng.Xml;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-27 16:34:19                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Extensions
{
    /// <summary>
    /// 扩展属性
    /// </summary>
    public class Property
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Property()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 扩展属性名称
        /// </summary>
        [XmlAttribute]
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// 扩展属性值类型
        /// </summary>
        [XmlAttribute]
        [Required]
        public string Type { get; set; }
        /// <summary>
        /// 值
        /// </summary>
        [XmlCData]
        public string Value { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}