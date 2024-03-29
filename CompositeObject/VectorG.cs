using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Attributes;
using XiaoFeng.Ofd.BaseType;
using XiaoFeng.Ofd.BasicStructure;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-27 14:32:04                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.CompositeObject
{
    /// <summary>
    /// 矢量图像
    /// </summary>
    public class VectorG
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public VectorG()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 矢量图像的宽度，超出部分作裁剪处理
        /// </summary>
        [XmlAttribute]
        [Required]
        public double Width { get; set; }
        /// <summary>
        /// 矢量图像的高度，超出部分作裁剪处理
        /// </summary>
        [XmlAttribute]
        [Required]
        public double Height { get; set; }
        /// <summary>
        /// 缩略图，指向包内的图像文件
        /// </summary>
        public STRefID Thumbnail { get; set; }
        /// <summary>
        /// 替换图像，用于高分辨率输出时将缩略图替换为此高分辨率的图像，指向包内的图像文件
        /// </summary>
        public STRefID Substitution { get; set; }
        /// <summary>
        /// 内容的矢量描述
        /// </summary>
        [Required]
        public IPageBlock Content { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}