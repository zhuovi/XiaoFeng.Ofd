using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Internal;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-28 16:07:27                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Signatures
{
    /// <summary>
    /// 签名要保护的原文及本次签名相关的信息
    /// </summary>
    public class SignedInfo
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public SignedInfo()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 创建签名时所用的签章提供者信息
        /// </summary>
        public Provider Provider { get; set; }
        /// <summary>
        /// 签名方法，记录安全模块返回的签名算法代码，以便验证时使用
        /// </summary>
        public string SignatureMethod { get; set; }
        /// <summary>
        /// 签名时间，记录安全模块返回的签名时间，以便验证时使用
        /// </summary>
        public string SignatureDateTime { get; set; }
        /// <summary>
        /// 包内文件计算所得的摘要记录列表，一个受本次签名保护的包内文件对应一个 <see cref="Reference"/> 节点
        /// </summary>
        public References References { get; set; }
        /// <summary>
        /// 本签名关联的外观（用 OFD 中的注释来表示），该节点可出现多次
        /// </summary>
        [XmlArrayItem]
        public List<StampAnnot> StampAnnots { get; set; }
        /// <summary>
        /// 电子印章信息
        /// </summary>
        public Seal Seal { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}