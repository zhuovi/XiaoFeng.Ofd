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
*  Create Time : 2024-03-26 21:26:35                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Models
{
    /// <summary>
    /// 高洛德渐变
    /// </summary>
    public class GouraudShd
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public GouraudShd()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 在渐变控制点所确定范围之外的部分是否填充，0为不填充，1表示填充，默认值为0
        /// </summary>
        [XmlAttribute]
        public int Extend { get; set; }
        /// <summary>
        /// 渐变控制点，至少出现3个
        /// </summary>
        public List<Point> Point { get; set; }
        /// <summary>
        /// 渐变范围外的填充颜色，应使用基本颜色
        /// </summary>
        public Color BackColor { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}