﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Attributes;
using XiaoFeng.Ofd.BaseType;
using XiaoFeng.Ofd.Enum;
using XiaoFeng.Xml;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 21:12:58                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.PageDescription
{
    /// <summary>
    /// <para>颜色空间</para>
    /// <para>详情说明 见图 <see langword="24"/> ，见表 <see langword="25"/> </para>
    /// </summary>
    public class ColorSpace
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public ColorSpace()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 颜色空间ID
        /// </summary>
        [XmlAttribute]
        public STID ID { get; set; }
        /// <summary>
        /// 的类型
        /// </summary>
        [XmlAttribute]
        [Required]
        [XmlConverter(typeof(StringEnumConverter))]
        public ColorSpaceType Type { get; set; }
        /// <summary>
        /// 每个颜色通道所使用的位数，有效取值为1，2，4，8，16。默认为8
        /// </summary>
        [XmlAttribute]
        public int? BitsPerComponent { get; set; }
        /// <summary>
        /// 指向包内颜色配置文件
        /// </summary>
        [XmlAttribute]
        public Location Profile { get; set; }
        /// <summary>
        /// 调色板
        /// </summary>
        public Palette Palette { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}