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
*  Create Time : 2024-03-27 10:52:39                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.PageDescription
{
    /// <summary>
    /// <para>剪切区</para>
    /// <para>裁剪区由一组路径或文字构成，用以指定页面上：的一个有效绘制区域，落在裁剪区以外的部分不受绘制指令的影响。</para>
///<para>一个裁前区可由多个分路径(Area)组成，最终的裁剪范围是各个分路径的并集。裁剪区中的数据均相对于所修饰图元对象的外接矩形。</para>
    /// <para>详情说明 见图 <see langword="44"/> ，见表 <see langword="33"/> </para>
    /// </summary>
    public class Clip
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Clip()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 裁剪区域，用一个图形对象或文字对象来描述裁剪区的一个组成部分，最终裁剪区是这些区域的并集
        /// </summary>
        [XmlArrayItem]
        public List<ClipArea> Areas { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}