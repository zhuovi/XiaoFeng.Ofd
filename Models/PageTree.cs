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
*  Create Time : 2024-03-26 19:52:55                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Models
{
    /// <summary>
    /// 页树
    /// </summary>
    public class PageTree
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public PageTree()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 声明该页的标识，不能与已有的标识重复
        /// </summary>
        [XmlAttribute]
        [Required]
        public STID ID { get; set; }
        /// <summary>
        /// 指向页对象描述文件
        /// </summary>
        [XmlAttribute]
        [Required] 
        public Location BaseLoc { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}