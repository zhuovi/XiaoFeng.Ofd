using System;
using System.Collections.Generic;
using System.Text;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-27 09:34:11                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Enum
{
    /// <summary>
    /// 翻转方式
    /// </summary>
    public enum ReflectMethod
    {
        /// <summary>
        /// 典型的
        /// </summary>
        Normal =0 ,
        /// <summary>
        /// 纵向翻转
        /// </summary>
        Column =1 ,
        /// <summary>
        /// 横向翻转
        /// </summary>
        Row =2 ,
        /// <summary>
        /// 横向和纵向翻转
        /// </summary>
        RowAndColumn =3 
    }
}