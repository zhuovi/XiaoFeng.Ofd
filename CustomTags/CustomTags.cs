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
*  Create Time : 2024-03-27 16:23:24                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.CustomTags
{
    /// <summary>
    /// 自定义标引列表
    /// </summary>
    public class CustomTags
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public CustomTags()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 自定义标引集合
        /// </summary>
        [XmlArrayItem("CustomTag")]
        public List<CustomTag> Tags { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}