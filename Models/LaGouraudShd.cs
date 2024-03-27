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
namespace XiaoFeng.Ofd.Models
{
    /// <summary>
    /// 网络高洛德渐变
    /// </summary>
    public class LaGouraudShd:GouraudShd
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
        public int VerticesperRow { get;set; }
        /// <summary>
        /// 渐变控制点，至少出现4个
        /// </summary>
        public new List<Point> Point { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}