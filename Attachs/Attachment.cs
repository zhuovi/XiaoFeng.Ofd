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
*  Create Time : 2024-03-26 16:09:50                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Attachs
{
    /// <summary>
    /// 附件
    /// </summary>
    public class Attachment
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Attachment()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 附件标识
        /// </summary>
        [XmlAttribute]
        [Required]
        public STID ID { get; set; }
        /// <summary>
        /// 附件名称
        /// </summary>
        [XmlAttribute]
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// 附件格式
        /// </summary>
        [XmlAttribute]
        public string Format { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlAttribute]
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlAttribute]
        public DateTime ModDate { get; set; }
        /// <summary>
        /// 附件大小，以KB为单位
        /// </summary>
        [XmlAttribute]
        public double Size { get; set; }
        /// <summary>
        /// 附件是否可见
        /// </summary>
        [XmlAttribute]
        public bool Visible { get; set; } = true;
        /// <summary>
        /// 附件用途
        /// </summary>
        [XmlAttribute]
        public string Usage { get; set; } = "none";
        /// <summary>
        /// 附件内容在包内的路径
        /// </summary>
        public Location FileLoc { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}