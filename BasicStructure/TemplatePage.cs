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
*  Create Time : 2024-03-26 18:48:26                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.BasicStructure
{
    /// <summary>
    /// <para>模板页结构</para>
    /// <para>详情说明 见图 <see langword="14"/> ，见表 <see langword="13"/> </para>
    /// </summary>
    public class TemplatePage
    {
        #region 构造器
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        public TemplatePage() { }
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="id">模板页的标识</param>
        /// <param name="baseLoc">指向模板页内容描述文件</param>
        /// <param name="name">模板页名称</param>
        /// <param name="zOrder">模板页的默认图层类型</param>
        public TemplatePage(STID id, Location baseLoc, string name = "", LayerType zOrder = LayerType.Background)
        {
            this.ID = id;
            this.BaseLoc = baseLoc;
            this.Name = name;
            this.ZOrder = zOrder;
        }
        #endregion

        #region 属性
        /// <summary>
        /// 模板页的标识，不能与已有的标识重复
        /// </summary>
        [XmlAttribute]
        [Required]
        public STID ID { get; set; }
        /// <summary>
        /// 模板页名称
        /// </summary>
        [XmlAttribute]
        public string Name { get; set; }
        /// <summary>
        /// 指向模板页内容描述文件
        /// </summary>
        [XmlAttribute]
        [Required]
        public Location BaseLoc { get; set; }
        /// <summary>
        /// 模板页的默认图层类型，其类型描述和呈现顺序与Layer中Type的描述和处理一致，见表15
        /// 如果页面引用的多个模板的此属性相同，则应根据引用的顺序来显示，先引用者先绘制
        /// 默认值 为Background
        /// </summary>
        [XmlAttribute]
        [XmlConverter(typeof(StringEnumConverter))]
        public LayerType ZOrder { get; set; } = LayerType.Background;
        #endregion

        #region 方法

        #endregion
    }
}