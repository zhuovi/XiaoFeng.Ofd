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
*  Create Time : 2024-03-26 16:02:55                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Models
{
    /// <summary>
    /// 文件描述
    /// </summary>
    public class File
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public File()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 文件标识 
        /// </summary>
        [XmlAttribute]
        [Required]
        public string ID { get; set; }
        /// <summary>
        /// 文件列表文件描述
        /// </summary>
        [XmlCData]
        [Required]
        public string Value { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}