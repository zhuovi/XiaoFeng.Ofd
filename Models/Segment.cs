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
*  Create Time : 2024-03-27 10:02:23                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Models
{
    /// <summary>
    /// 颜色段
    /// </summary>
    public class Segment
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Segment()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// <para>用于确定StartPoint和EndPoint中的各颜色的位置值,取值范围是[0，1.0],各段颜色的Position值应根据颜色出现的顺序递增第一个Segment的Position属性默认值为0, 最后一个Segment 的Position属性默认值为1.0, 当不存在时, 在空缺区间内平均分配</para>
        /// <para>举例:Segment个数等于2且不出现Position属性时,按照“01.0”处理; Segment个数等于3且不出现Position属性时,按照“00.51.0”处理;Segment个数等于5且不出现Position属性时,按照“00.25 0.5 0.75 1.0”处理</para>
        /// </summary>
        [XmlAttribute]
        public double Position { get; set; }
        /// <summary>
        /// 该段的颜色，应是基本颜色
        /// </summary>
        public List<Color> Color { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}