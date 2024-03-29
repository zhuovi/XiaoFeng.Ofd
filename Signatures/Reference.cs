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
*  Create Time : 2024-03-28 16:16:41                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Signatures
{
    /// <summary>
    /// 一个文件的摘要节点
    /// </summary>
    public class Reference
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Reference()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 指向包内的文件，使用绝对路径
        /// </summary>
        [XmlAttribute]
        [Required]
        public Location FileRef { get; set; }
        /// <summary>
        /// 对包内文件进行摘要计算，对所得的二进制摘要值进行 <see langword="base64"/> 编码所得结果
        /// </summary>
        public string CheckValue { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}