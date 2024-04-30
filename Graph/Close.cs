using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.BaseType;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-04-30 14:39:52                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Graph
{
    /// <summary>
    /// 自动闭合到当前分路径的起姑点，并以该点为当前点
    /// </summary>
    public class Close : IGraph
    {
        #region 构造器
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        public Close()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// ID
        /// </summary>
        [XmlAttribute]
        public STID ID { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}