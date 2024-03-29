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
*  Create Time : 2024-03-27 14:39:13                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Actions
{
    /// <summary>
    /// URI 动作
    /// </summary>
    public class URI
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public URI()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 目标 URI 的位置
        /// </summary>
        [XmlAttribute("URI")]
        [Required]
        public string Uri { get; set; }
        /// <summary>
        /// Base URI，用于相对地址
        /// </summary>
        public string Base { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}