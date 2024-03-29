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
*  Create Time : 2024-03-27 13:00:27                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Images
{
    /// <summary>
    /// 图像
    /// </summary>
    public class Image : GraphicUnit, IPageBlock
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Image()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 引用资源文件中定义的多媒体的标识
        /// </summary>
        [XmlAttribute]
        [Required]
        public STRefID ResourceID { get; set; }
        /// <summary>
        /// 可替换图像，引用资源文件中定义的多媒体的标识，用于某些情况如高分辨率输出时进行图像替换
        /// </summary>
        [XmlAttribute]
        public STRefID Substitution { get; set; }
        /// <summary>
        /// 图像蒙版，引用资源文件中定义的多媒体的标识，用作蒙版的图像应用是与 <see cref="ResourceID"/> 指向的图像相同大小的二值图
        /// </summary>
        [XmlAttribute]
        public STRefID ImageMask { get; set; }
        /// <summary>
        /// 图像边框
        /// </summary>
        public Border Border { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}