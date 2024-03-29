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
    /// 注释
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