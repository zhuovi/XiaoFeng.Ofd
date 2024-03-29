using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Attributes;
using XiaoFeng.Ofd.BaseType;
using XiaoFeng.Ofd.Enum;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 19:58:43                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.BasicStructure
{
    /// <summary>
    /// 模板页配置
    /// </summary>
    public class PageTemplate
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public PageTemplate()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 模板ID
        /// </summary>
        [XmlAttribute]
        [Required]
        public STRefID TemplateID { get; set; }
        /// <summary>
        /// 呈现顺序
        /// </summary>
        [XmlAttribute]
        [Required]
        public LayerType ZOrder { get; set; } = LayerType.Background;
        #endregion

        #region 方法

        #endregion
    }
}