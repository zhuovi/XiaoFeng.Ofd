using System;
using System.Collections.Generic;
using System.Text;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 15:22:20                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Attributes
{
    /// <summary>
    /// 必选项
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    public class RequiredAttribute : Attribute
    {
        #region 构造器
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        public RequiredAttribute()
        {

        }
        #endregion

        #region 属性

        #endregion

        #region 方法

        #endregion
    }
}