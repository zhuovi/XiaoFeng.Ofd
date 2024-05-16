using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.BaseType;
using XiaoFeng.Ofd.BasicStructure;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-05-15 15:29:34                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Annots
{
    /// <summary>
    /// Appearance 类说明
    /// </summary>
    public class Appearance
    {
        #region 构造器
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        public Appearance()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 区域
        /// </summary>
        [XmlAttribute]
        public Box Boundary { get; set; }
        /// <summary>
        /// 子节点
        /// </summary>
        public List<IPageBlock> PageBlocks { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}