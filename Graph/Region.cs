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
    /// <para>图形XML区域</para>
    /// <para>图形也可采用 XMI.复杂类型的方式进行描述，这种方式主要用于区域(Region),区域出一系列的分路径(Area)组成，每个分路径部是闭合的</para>
    /// <para>图形中的所有线条绘制都基丁“当前点”,当路径开始时，Area节点的Start 属性所指定的位置为当前点，之后以上一个线条的结束位置为当前点。</para>
    /// <para>详情说明 见图 <see langword="49"/> ，见表 <see langword="37"/> </para>
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