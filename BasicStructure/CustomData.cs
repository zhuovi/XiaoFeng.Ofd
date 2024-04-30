using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Xml;
/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 14:57:30                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.BasicStructure
{
    /// <summary>
    /// 自定义数据
    /// </summary>
    public class CustomData
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public CustomData()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 用户自定义元数据名称
        /// </summary>
        [XmlAttribute]
        public string Name { get; set; }
        /// <summary>
        /// 用户自定义元数据，可以指定一个名称及其对应的值
        /// </summary>
        [XmlText]
        public string Value { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}