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
*  Create Time : 2024-03-27 16:04:40                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Annots
{
    /// <summary>
    /// 注释所在的页
    /// </summary>
    public class AnnotationPage
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public AnnotationPage()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 引用注释所在的页面的标识
        /// </summary>
        [XmlAttribute]
        [Required]
        public STRefID PageID { get; set; }
        /// <summary>
        /// 指向包内的分页注释文件
        /// </summary>
        public Location FileLoc { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}