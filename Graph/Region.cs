using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-27 12:02:59                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Graph
{
    /// <summary>
    /// 图形XML 区域
    /// </summary>
    public class Region
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Region()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 区域
        /// </summary>
        [XmlArrayItem("Area")]
        public List<RegionArea> Areas { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}