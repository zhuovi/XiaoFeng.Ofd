using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Attributes;
using XiaoFeng.Ofd.Internal;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 21:18:49                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Models
{
    /// <summary>
    /// 调色板
    /// </summary>
    public class Palette
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Palette()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 调色板中预定义颜色，调色板中颜色的索引编号从0开始
        /// </summary>
        public STArray CV { get; set; }
        
        #endregion

        #region 方法

        #endregion
    }
}