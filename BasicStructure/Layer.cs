using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.BaseType;
using XiaoFeng.Ofd.Enum;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 20:07:55                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.BasicStructure
{
    /// <summary>
    /// 图层
    /// </summary>
    public class Layer : IPageBlock
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Layer()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 层描述类型
        /// </summary>
        [XmlAttribute]
        public LayerType Type { get; set; } = LayerType.Body;
        /// <summary>
        /// 图层的绘制参数，引用资源文件中定义的绘制参数标识
        /// </summary>
        [XmlAttribute]
        public STRefID DrawParam { get; set; }
        /// <summary>
        /// 页面块
        /// </summary>
        [XmlArrayItem]
        public List<IPageBlock> PageBlock { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}