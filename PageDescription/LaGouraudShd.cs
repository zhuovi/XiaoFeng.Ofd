using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Attributes;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 21:26:46                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.PageDescription
{
    /// <summary>
    /// <para>网络高洛德渐变</para>
    /// <para>网格高洛德渐变是高洛德渐变的一种特殊形式，其允许定义4个以上的控制点，按照每行固定的网    格数(VerticesPerRow)形成若十行列，相邻的4个控制点定义一个网格单元，在一个网格单元内 EdgeFlog 固定为1, 网格单元及多个单元组成网格区城的规则如图42所示</para>
    /// <para>详情说明 见图 <see langword="43"/> ，见表 <see langword="32"/> </para>
    /// </summary>
    public class LaGouraudShd : GouraudShd
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public LaGouraudShd()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 渐变区域内每行的网络数
        /// </summary>
        [XmlAttribute]
        [Required]
        public int VerticesperRow { get; set; }
        /// <summary>
        /// 渐变控制点，至少出现4个
        /// </summary>
        public new List<Point> Point { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}