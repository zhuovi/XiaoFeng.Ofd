using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Attributes;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 19:03:48                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Models
{
    /// <summary>
    /// 打印权限
    /// </summary>
    public class Print
    {
        #region 构造器
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        public Print() { }
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="printable">文档是否允许被打印</param>
        /// <param name="copics">打印份数</param>
        public Print(bool printable, int copics)
        {
            Printable = printable;
            Copics = copics;
        }

        #endregion

        #region 属性
        /// <summary>
        /// 文档是否允许被打印
        /// </summary>
        [XmlAttribute]
        public Boolean Printable { get; set; } = true;
        /// <summary>
        /// 打印份数，在 <see cref="Printable"/> 为true时有效，若 <see cref="Printable"/> 为true并且不设置 <see cref="Copics"/> 则打印份数不受限，若 <see cref="Copics"/> 的值为负值时，打印份数不受限，当 <see cref="Copics"/> 的值为0时，不允许打印，当 <see cref="Copics"/> 的值大于0时，则代表实际 可打印的份数值
        /// </summary>
        [XmlAttribute] 
        public int Copics { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}