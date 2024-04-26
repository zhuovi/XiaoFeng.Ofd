using System;
using System.Collections.Generic;
using System.Text;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-04-24 14:11:34                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Attributes
{
    /// <summary>
    /// 文档路径
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Field | AttributeTargets.Property)]
    public class XmlPathAttribute : Attribute
    {
        #region 构造器
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        public XmlPathAttribute() { }
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="filePath">文件路径</param>
        public XmlPathAttribute(string filePath) => this.FilePath = filePath;
        #endregion

        #region 属性
        /// <summary>
        /// 文件路径
        /// </summary>
        public string FilePath { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}