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
*  Create Time : 2024-03-28 16:21:40                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Signatures
{
    /// <summary>
    /// 签名的外观
    /// </summary>
    public class StampAnnot
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public StampAnnot()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 签章注释的标识
        /// </summary>
        [XmlAttribute]
        [Required]
        public STID ID { get; set; }
        /// <summary>
        /// 引用外观注释所在的页面的标识
        /// </summary>
        [XmlAttribute]
        [Required]
        public STRefID PageRef { get; set; }
        /// <summary>
        /// 签章注释的外观外边框位置，可用于签章注释在页面内的定位
        /// </summary>
        [XmlAttribute]
        [Required]
        public Box Boundary { get; set; }
        /// <summary>
        /// 签章注释的外观裁剪设置
        /// </summary>
        [XmlAttribute]
        public Box Clip { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}