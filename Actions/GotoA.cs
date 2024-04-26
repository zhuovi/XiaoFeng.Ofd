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
*  Create Time : 2024-03-27 14:39:26                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Actions
{
    /// <summary>
    /// <para>附件动作</para>
    /// <para>附件动作表明打开当前文档内的一个附件</para>
    /// <para>详情说明 见图 <see langword="76"/> ，见表 <see langword="55"/> </para>
    /// </summary>
    public class GotoA
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public GotoA()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 附件标识
        /// </summary>
        [XmlAttribute]
        [Required]
        public STRefID AttachID { get; set; }
        /// <summary>
        /// 是否在新窗口中打开
        /// </summary>
        [XmlAttribute]
        public bool NewWindow { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}