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
*  Create Time : 2024-03-27 16:46:41                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Signatures
{
    /// <summary>
    /// 签名列表
    /// </summary>
    [Required]
    public class Signatures
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Signatures()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 安全标识的最大值，作用与文档入口文件 Document.xml 中的 MaxID 相同，为了避免在签名时影响文档入口文件，采用了与ST_ID不一样的ID编码方式。推荐使用“sNNN”的编码方式，NNN从1开始
        /// </summary>
        public STID MaxSignId { get; set; }
        /// <summary>
        /// 签名节点集合
        /// </summary>
        [XmlArrayItem("SignatureNode")]
        public List<SignatureNode> SignatureNodes { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}