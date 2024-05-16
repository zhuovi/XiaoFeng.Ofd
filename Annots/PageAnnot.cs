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
*  Create Time : 2024-03-27 16:07:31                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Annots
{
    /// <summary>
    /// <para>分页注释</para>
    /// <para>详情说明 见图 <see langword="81"/> ，见表 <see langword="61"/> </para>
    /// </summary>
    public class PageAnnot : XmlEntity<PageAnnot>
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public PageAnnot()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 分页注释文件集合
        /// </summary>
        [XmlArrayItem("Annot")]
        public List<Annot> Annots { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}