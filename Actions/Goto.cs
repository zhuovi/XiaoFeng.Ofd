using System;
using System.Collections.Generic;
using System.Text;
using XiaoFeng.Ofd.Attributes;
using XiaoFeng.Ofd.BasicStructure;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-27 14:38:59                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Actions
{
    /// <summary>
    /// 跳转动作
    /// </summary>
    public class Goto
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Goto()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 跳转的目标区域
        /// </summary>
        [Required]
        public Dest Dest { get; set; }
        /// <summary>
        /// 跳转的目标不书签
        /// </summary>
        [Required]
        public Bookmark Bookmark { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}