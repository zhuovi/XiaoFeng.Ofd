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
    /// 文件摘要
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