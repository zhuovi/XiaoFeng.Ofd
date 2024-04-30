using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Attributes;
using XiaoFeng.Ofd.BaseType;
using XiaoFeng.Ofd.CompositeObject;
using XiaoFeng.Ofd.Fonts;
using XiaoFeng.Ofd.Internal;
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
    /// <para>详情说明 见图 <see langword="20"/> ，见表 <see langword="18"/> </para>
    /// </summary>
    public class Res:XmlEntity<Res>
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
        /// 定义此资源文件的通用数据存储路径，BascLoc 属性的意义在于明确资源文件存储的位置，比如K1.xml中可以指定 Bascloc为“./Res”,表明该资源文件中所有数据文件的默认仔储位置在当前路径的 Res目录下
        /// </summary>
        [XmlAttribute]
        [Required]
        public Location BaseLoc { get; set; } = "Res";
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
        /// <summary>
        /// 添加绘制参数的描述
        /// </summary>
        /// <param name="drawParam">绘制参数的描述</param>
        public void AddDrawParam(DrawParam drawParam)
        {
            if (this.DrawParams == null) this.DrawParams = new List<DrawParam>();
            this.DrawParams.Add(drawParam);
        }
        /// <summary>
        /// 添加文档所用字形的描述
        /// </summary>
        /// <param name="font">文档所用字形的描述</param>
        public void AddFont(Font font)
        {
            if (this.Fonts == null) this.Fonts = new List<Font>();
            this.Fonts.Add(font);
        }
        /// <summary>
        /// 添加文档所用多媒体对象的描述
        /// </summary>
        /// <param name="multiMedia">文档所用多媒体对象的描述</param>
        public void AddMultiMedia(MultiMedia multiMedia)
        {
            if (this.MultiMedias == null) this.MultiMedias = new List<MultiMedia>();
            this.MultiMedias.Add(multiMedia);
        }
        /// <summary>
        /// 添加矢量图像（被复合图元对象所引用）的描述
        /// </summary>
        /// <param name="vectorG">矢量图像（被复合图元对象所引用）的描述</param>
        public void AddCompositeGraphicUnit(VectorG vectorG)
        {
            if (vectorG == null) return;
            if (this.CompositeGraphicUnits == null) this.CompositeGraphicUnits = new List<VectorG>();
            this.CompositeGraphicUnits.Add(vectorG);
        }
        #endregion
    }
}