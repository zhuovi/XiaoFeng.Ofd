using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Attributes;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-28 16:08:42                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Signatures
{
    /// <summary>
    /// 创建签名时所用的签章组件提供者
    /// </summary>
    public class Provider
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Provider()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 创建签名时所用的签章组件的提供者名称
        /// </summary>
        [XmlAttribute]
        [Required]
        public string ProviderName { get; set; }
        /// <summary>
        /// 创建签名时所用的签章组件的版本
        /// </summary>
        [XmlAttribute]
        public string Version { get; set; }
        /// <summary>
        /// 创建签名时所用的签章组件的制造商
        /// </summary>
        [XmlAttribute]
        public string Company { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}