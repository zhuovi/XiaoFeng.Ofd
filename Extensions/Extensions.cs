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
*  Create Time : 2024-03-27 16:27:54                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Extensions
{
    /// <summary>
    /// <para>扩展信息列表</para>
    /// <para>扩展信息列表的入口点在7.5文档根节点中定义。扩展信息列表文件的根节点名为 Extensions,其下由0到多个扩展信息节点(Extension)组成</para>
    /// <para>详情说明 见图 <see langword="83"/> ，见表 <see langword="64"/> </para>
    /// </summary>
    public class Extensions
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Extensions()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 扩展信息集合
        /// </summary>
        [XmlArrayItem("Extension")]
        public List<Extension> Extension { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}