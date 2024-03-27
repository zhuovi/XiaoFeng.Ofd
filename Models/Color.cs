using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Internal;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 21:10:10                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Models
{
    /// <summary>
    /// 颜色
    /// </summary>
    public class Color
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Color()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 颜色值,指定了当前颜色空间下各通道的取值。Value的取值应符合"通道1通道2通道3…"格式。此属性不出现时,应采用Index属性从颜色空间的调色板中的取值。当二者都不出现时,该颜色各通道的值全部为0
        /// </summary>
        [XmlAttribute]
        public STArray Value { get; set; }
        /// <summary>
        /// 调色板中颜色的编号,非负整数,将从当前颜色空间的调色板中取出相应索引的预定义颜色用来绘制。索引从0开始
        /// </summary>
        [XmlAttribute]
        public int Index { get; set; }
        /// <summary>
        /// 引用资源文件中颜色空间的标识，默认值为文档设定的颜色空间
        /// </summary>
        [XmlAttribute]
        public STRefID ColorSpace { get; set; }
        /// <summary>
        /// 颜色透明度,在0~255之间取值。默认为255,表示完全不透明
        /// </summary>
        [XmlAttribute]
        public int Alpha { get; set; }
        /// <summary>
        /// 底纹填充，复杂颜色的一种。描述见8.3.3
        /// </summary>
        public Pattern Pattern { get; set; }
        /// <summary>
        /// 轴向渐变，复杂颜色的一种。描述见8.3.4.2
        /// </summary>
        public AxialShd AxialShd { get; set; }
        /// <summary>
        /// 径向渐变，复杂颜色的一种。描述见8.4.3
        /// </summary>
        public RadialShd RadialShd { get; set; }
        /// <summary>
        /// 高洛德渐变，复杂颜色的一种。描述见8.3.4.4
        /// </summary>
        public GouraudShd GouraudShd { get; set;}
        /// <summary>
        /// 格构高洛德渐变，复杂颜色的一种。描述见8.3.4.5
        /// </summary>
        public LaGouraudShd LaGouraudShd { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}