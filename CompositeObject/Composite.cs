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
    /// <para>复合对象</para>
    /// <para>复合对象是一种特殊的图元对象，拥有图元对象的一切特性，但其内容在 ResourceID指向的矢量图像资源中进行描述，一个资源可以被多个复合对象所引用，通过这种方式可实现对文档内矢量图文内容的复用。</para>
    /// <para>详情说明 见图 <see langword="71"/> ，见表 <see langword="49"/> </para>
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
        ///<inheritdoc/>
        public override string ToString()
        {
            return $"{this.ResourceID}[{this.Boundary}]";
        }
        #endregion
    }
}