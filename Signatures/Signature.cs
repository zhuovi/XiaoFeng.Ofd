using System;
using System.Collections.Generic;
using System.Text;
using XiaoFeng.Ofd.BaseType;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-27 17:05:45                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Signatures
{
    /// <summary>
    /// <para>文件摘要</para>
    /// <para>)FD的数字签名通过对签名描述文件的保护间接实现对)FD原文的保护。签名结构中的签名信息(Signedlnfo)是这一过程中的关键节点，其中记录了当次数宁签名保护的所有文件的二进制摘要信息，同时将安全算法提供者、签名算法、签名时间和所应用的安全印章等信息也包含在此节点内。签名措述文件同时包含了签名值将要存放的包内位置，一旦对该文件实施签名保护，则其对应的包内文件原文以及本次签名对应的附加信息都将不可改动，从而实现一次数字签名对整个原文内容的保护。签名描述文件的主要结构描述见图86。</para>
    /// <para>详情说明 见图 <see langword="86"/> ，见表 <see langword="67"/> </para>
    /// </summary>
    public class Signature
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Signature()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 签名要保护的原文件及本次签名相关的信息
        /// </summary>
        public SignedInfo SignedInfo { get; set; }
        /// <summary>
        /// 指向安全签名提供者所返回的针对签名描述文件计算所得的签名值文件
        /// </summary>
        public Location SignedValue { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}