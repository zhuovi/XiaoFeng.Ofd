using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Attributes;
using XiaoFeng.Ofd.BaseType;
using XiaoFeng.Ofd.Enum;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-27 16:55:46                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Signatures
{
    /// <summary>
    /// 签名列表节点
    /// </summary>
    public class SignatureNode
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public SignatureNode()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 签名或签章的标识
        /// </summary>
        [XmlAttribute]
        [Required]
        public STID ID { get; set; }
        /// <summary>
        /// 签名节点类型
        /// </summary>
        [XmlAttribute]
        public SignatureType Type { get; set; }
        /// <summary>
        /// 指向包内的签名描述文件
        /// </summary>
        [XmlAttribute]
        [Required]
        public Location BaseLoc { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}