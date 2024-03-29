using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Attributes;
using XiaoFeng.Ofd.BaseType;
using XiaoFeng.Ofd.CompositeObject;
using XiaoFeng.Ofd.Fonts;
using XiaoFeng.Ofd.PageDescription;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-28 18:45:55                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.BasicStructure
{
    /// <summary>
    /// <para>资源</para>
    /// <para>资源是绘制图元时所需数据(如绘制参数、颜色空间、字型、图像、音视频等)的集合。在页面中出现的资源数据内容都保存在容器的特定文件夹内，但其索引信息保存在资源文件中。一个文档可能包含一个或多个资源文件。资源根据其作用范围分为公共资源和贞资源。公共资源文件在文档根节点中进行指定，页资源文件在页对象中进行指定。</para>
    /// <para>图 20 ，表 18</para>
    /// </summary>
    public class Res
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Res()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 定义此资源文件的通用数据存储路径，BascLoc 属性的意义在于明确资源文件存储的位置，比如K1.xml中可以指定 Bascloc为“./Res”,表明该资源文件中所有数据文件的默认仔储位置在当前路径的 Rcs目录下
        /// </summary>
        [XmlAttribute]
        [Required]
        public Location BaseLoc { get; set; }
        /// <summary>
        /// 包含了一组颜色空间的描述
        /// </summary>
        public List<ColorSpace> ColorSpaces { get; set; }
        /// <summary>
        /// 包含了一组绘制参数的描述
        /// </summary>
        public List<DrawParam> DrawParams { get; set; }
        /// <summary>
        /// 包含了一组文档所用字形的描述
        /// </summary>
        public List<Font> Fonts { get; set; }
        /// <summary>
        /// 包含了一组文档所用多媒体对象的描述
        /// </summary>
        public List<MultiMedia> MultiMedias { get; set; }
        /// <summary>
        /// 包含了一组矢量图像（被复合图元对象所引用）的描述
        /// </summary>
        public List<VectorG> CompositeGraphicUnits { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}