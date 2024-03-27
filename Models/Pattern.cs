using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Attributes;
using XiaoFeng.Ofd.Enum;
using XiaoFeng.Ofd.Internal;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 21:26:04                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Models
{
    /// <summary>
    /// 底纹
    /// </summary>
    public class Pattern
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Pattern()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 底纹单元的宽度
        /// </summary>
        [XmlAttribute]
        [Required]
        public double Width { get; set; }
        /// <summary>
        /// 底纹单元的高度
        /// </summary>
        [XmlAttribute]
        [Required]
        public double Height { get; set; }
        /// <summary>
        /// X方向底纹单元间距，默认值为底纹单元的宽度。若设定值小于底纹单元的宽度时，应按默认值处理
        /// </summary>
        [XmlAttribute]
        [Required]
        public double XStep { get; set; }
        /// <summary>
        /// Y方向底纹单元间距，默认值为底纹单元的高度。若设定值小于底纹单元的高度时，应按默认值处理
        /// </summary>
        [XmlAttribute]
        [Required]
        public double YStep { get; set; }
        /// <summary>
        /// 描述底纹单元的映像翻转方式，枚举值，默认值为Normal
        /// </summary>
        [XmlAttribute]
        [Required]
        public ReflectMethod ReflectMethod { get; set; } = ReflectMethod.Normal;
        /// <summary>
        /// 底纹单元起始绘制位置
        /// </summary>
        [XmlAttribute]
        [Required]
        public RelativeType RelativeTo { get; set; }
        /// <summary>
        /// 底纹单元的变换矩阵，用于某些需要对底纹单元进行平移旋转变换的场合，默认为单位矩阵；底纹呈现时先做XStep,YStep排列，然后一起作CTM处理
        /// </summary>
        [XmlAttribute]
        [Required]
        public STArray CTM { get; set; }
        /// <summary>
        /// 底纹单元，用于底纹填充目标区域时，所使用的单元对象
        /// </summary>
        public List<IPageBlock> CellContent { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}