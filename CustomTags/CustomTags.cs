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
    /// <para>自定义标引列表</para>
    /// <para>外部系统或用户可以添加自定义的标记和信息，从而达到与其他系统、数据进行交互的日的并扩展应用。一个文档可以带有多个自定义标引。</para>
    /// <para>详情说明 见图 <see langword="82"/> ，见表 <see langword="63"/> </para>
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