using System;
using System.Collections.Generic;
using System.Text;
using XiaoFeng.Ofd.BaseType;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-28 16:26:58                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Signatures
{
    /// <summary>
    /// 电子印章信息
    /// </summary>
    public class Seal
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Seal()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 指向包内的安全电子印章文件，遵循密码领域的相关规范
        /// </summary>
        public Location BaseLoc { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}