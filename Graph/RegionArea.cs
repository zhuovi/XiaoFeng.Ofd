using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Attributes;
using XiaoFeng.Ofd.BaseType;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-27 12:03:30                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Graph
{
    /// <summary>
    /// 区域分路径
    /// <para>详情说明 见图 <see langword="49"/> </para>
    /// </summary>
    public class RegionArea
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public RegionArea()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 定义子图形的起始点坐标
        /// </summary>
        [XmlAttribute]
        [Required]
        public Position Start { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}