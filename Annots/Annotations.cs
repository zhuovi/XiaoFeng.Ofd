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
*  Create Time : 2024-03-27 16:03:45                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Annots
{
    /// <summary>
    /// <para>注释</para>
    /// <para>注释是版式文档形成后附加的图文信总，用户可通过鼠标或键盘与其进行交互。本标准中，页面内容与注释内容是分文件描述的。文档的注释在注释列表文件中按照页面进行组织索引，注释的内容在分页注释文件中描述</para>
    /// <para>详情说明 见图 <see langword="80"/> ，见表 <see langword="60"/> </para>
    /// </summary>
    public class Annotations
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Annotations()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 注释所在的页集合
        /// </summary>
        [XmlArrayItem("Page")]
        public List<AnnotationPage> Pages { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}