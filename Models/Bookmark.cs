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
*  Create Time : 2024-03-26 19:30:24                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Models
{
    /// <summary>
    /// 书签
    /// </summary>
    public class Bookmark
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Bookmark()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 书签名称
        /// </summary>
        [XmlAttribute]
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// 书签对应的文档位置，见表54
        /// </summary>
        [Required]
        public Dest Dest { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}