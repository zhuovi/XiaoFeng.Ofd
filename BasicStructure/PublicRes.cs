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
*  Create Time : 2024-04-24 18:13:38                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.BasicStructure
{
    /// <summary>
    /// 公共资源
    /// </summary>
    [XmlPath("Doc_{0}/PublicRes.xml")]
    [XmlRoot("Res")]
    public class PublicRes : Res
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public PublicRes()
        {

        }
        #endregion

        #region 属性

        #endregion

        #region 方法

        #endregion
    }
}