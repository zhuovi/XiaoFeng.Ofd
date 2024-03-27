using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Attributes;
using XiaoFeng.Ofd.Internal;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 15:28:47                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Models
{
    /// <summary>
    /// 版本描述
    /// </summary>
    public class Version
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Version()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 版本标识 
        /// </summary>
        [XmlAttribute]
        [Required] 
        public string ID { get; set; }
        /// <summary>
        /// 版本号
        /// </summary>
        [XmlAttribute]
        [Required] 
        public int Index { get; set; }
        /// <summary>
        /// 是否是默认版本
        /// </summary>
        [XmlAttribute] 
        public Boolean Current { get; set; }
        /// <summary>
        /// 指向包内的版本描述文件
        /// </summary>
        [XmlAttribute]
        [Required]
        public Location BaseLoc { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}