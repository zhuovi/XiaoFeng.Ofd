using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Json;
using XiaoFeng.Ofd.Attributes;
using XiaoFeng.Ofd.BasicStructure;
using XiaoFeng.Ofd.Enum;
using XiaoFeng.Ofd.PageDescription;
using XiaoFeng.Xml;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-27 11:47:52                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Graph
{
    /// <summary>
    /// <para>图形对象</para>
    /// <para>图形对象具有一般图元对象的一切属性和行为特征。</para>
    /// <para>详情说明 见图 <see langword="46"/> ，见表 <see langword="35"/> </para>
    /// </summary>
    public class PathObject : GraphicUnit, IPageBlock
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public PathObject()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 图形是否被勾边，默认值为true
        /// </summary>
        [XmlAttribute]
        public bool Stroke { get; set; } = true;
        /// <summary>
        /// 图形是否被填充，默认值为false
        /// </summary>
        [XmlAttribute]
        public bool Fill { get; set; }
        /// <summary>
        /// 图形的填充规则，当Fill属性存在时出现，默认值为NonZero
        /// </summary>
        [XmlAttribute]
        [XmlConverter(typeof(EnumNameConverter))]
        public FillRule Rule { get; set; }
        /// <summary>
        /// 填充颜色，默认为透明色
        /// </summary>
        public Color FillColor { get; set; }
        /// <summary>
        /// 勾边颜色，默认为黑色
        /// </summary>
        public Color StrokeColor { get; set; }
        /// <summary>
        /// 图形轮廓数据，由一系列紧缩的操作符和操作数构成
        /// </summary>
        [Required]
        public string AbbreviatedData { get; set; }
        #endregion

        #region 方法
        ///<inheritdoc/>
        public override string ToString()
        {
            return $"{this.AbbreviatedData}";
        }
        #endregion
    }
}