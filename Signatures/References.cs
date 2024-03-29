using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-28 16:15:06                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Signatures
{
    /// <summary>
    /// 签名范围
    /// </summary>
    public class References
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public References()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 摘要方法，视应用场景的不同使用不同的摘要方法。用于各行业应用时，应使用符合该行业安全标准的算法
        /// </summary>
        [XmlAttribute]
        public string CheckMethod { get; set; }
        /// <summary>
        /// 针对一个文件的摘要节点
        /// </summary>
        [XmlArrayItem]
        public List<Reference> Reference { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}