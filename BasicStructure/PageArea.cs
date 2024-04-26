using System;
using System.Collections.Generic;
using System.Text;
using XiaoFeng.Ofd.Attributes;
using XiaoFeng.Ofd.BaseType;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 17:18:22                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.BasicStructure
{
    /// <summary>
    /// <para>页面区域结构</para>
    /// <para>详情说明 见图 <see langword="7"/> ，见表 <see langword="7"/> </para>
    /// </summary>
    public class PageArea
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public PageArea()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 页面物理区域，左上角的坐标为页面空间坐标系的原点
        /// </summary>
        [Required]
        public Box PhysicalBox { get; set; }
        /// <summary>
        /// <para>显示区域,页面内容实际显示或打印输出的区域,位于页面物理区域内,包含页眉、页脚、版心等内容</para>
        /// <para>[例外处理]如果显示区域不完全位于页面物理区域内,页面物理区域外的部分则被忽略。如果显示区域完全位于页面物理区域外,则该页为空白页</para>
        /// </summary>
        public Box ApplicationBox { get; set; }
        /// <summary>
        /// <para>版心区域,即文件的正文区域,位于显示区域内。左上角的坐标决定了其在显示区域内的位置</para>
        /// <para>[例外处理]如果版心区域不完全位于显示区域内，显示区域外的部分则被忽略。如果版心区域完全位于显示区域外,则版心内容不被绘制</para>
        /// </summary>
        public Box ContentBox { get; set; }
        /// <summary>
        /// <para>出血区域,即超出设备性能限制的额外出血区域,位于页面物理区域外。不出现时,默认值为页面物理区域</para>
        /// <para>[例外处理]如果出血区域不完全位于页面物理区域外,页面物理区域内的部分则被忽略。如果出血区域无效</para>
        /// </summary>
        public Box BleedBox { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}