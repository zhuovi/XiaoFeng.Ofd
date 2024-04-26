using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Attributes;
using XiaoFeng.Ofd.BaseType;

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
namespace XiaoFeng.Ofd.BasicStructure
{
    /// <summary>
    /// <para>页树</para>
    /// <para>详情说明 见图 <see langword="12"/> ，见表 <see langword="11"/> </para>
    /// </summary>
    public class PageTree
    {
        #region 构造器
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        public PageTree() { }
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="id">页面树ID</param>
        /// <param name="baseLoc">页面地址</param>
        public PageTree(STID id, Location baseLoc)
        {
            ID = id;
            BaseLoc = baseLoc;
        }
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="id">页面树ID</param>
        /// <param name="index">页面索引</param>
        public PageTree(uint id, uint index)
        {
            this.ID = id;
            this.BaseLoc = $"Pages/Page_{index}/Content.xml";
        }
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="id">页面树ID</param>
        /// <param name="index">页面索引</param>
        public PageTree(STID id, uint index) : this((uint)id, index) { }
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