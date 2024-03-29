using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Attributes;
using XiaoFeng.Ofd.BaseType;
using XiaoFeng.Ofd.BasicStructure;
using XiaoFeng.Ofd.PageDescription;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-27 14:29:31                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.CompositeObject
{
    /// <summary>
    /// 复合对象
    /// </summary>
    public class Composite : GraphicUnit, IPageBlock
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Composite()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 引用资源文件中定义的矢量图像的标识
        /// </summary>
        [XmlAttribute]
        [Required]
        public STRefID ResourceID { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}