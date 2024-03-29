using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Attributes;
using XiaoFeng.Ofd.BaseType;
using XiaoFeng.Ofd.Enum;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 19:47:54                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Actions
{
    /// <summary>
    /// 目标区域
    /// </summary>
    public class Dest
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Dest()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 目标不区域类型
        /// </summary>
        [XmlAttribute]
        [Required]
        public DestType Type { get; set; }
        /// <summary>
        /// 引用跳转目标不页面的标识
        /// </summary>
        [XmlAttribute]
        [Required]
        public STRefID PageID { get; set; }
        /// <summary>
        /// 目标区域左上角 x 坐标，默认为 <see langword="0"/>
        /// </summary>
        [XmlAttribute]
        public double Left { get; set; }
        /// <summary>
        /// 目标区域右上角 x 坐标
        /// </summary>
        [XmlAttribute]
        public double Right { get; set; }
        /// <summary>
        /// 目标区域左上角 y 坐标，默认为 <see langword="0"/>
        /// </summary>
        [XmlAttribute]
        public double Top { get; set; }
        /// <summary>
        /// 目标区域右上角 y 坐标
        /// </summary>
        [XmlAttribute]
        public double Bottom { get; set; }
        /// <summary>
        /// 目标区域页面缩放比例，为0或不出现则按照当前绽放比例跳转，可取值范围[0.1 64.0]
        /// </summary>
        [XmlAttribute]
        public double Zoom { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}