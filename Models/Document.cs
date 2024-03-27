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
*  Create Time : 2024-03-26 17:14:58                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Models
{
    /// <summary>
    /// 文档根节点
    /// </summary>
    public class Document
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Document()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 文档公共数据，定义了页面区域、公共资源等数据
        /// </summary>
        [Required]
        public List<CommonData> CommonData { get; set; }
        /// <summary>
        /// 页树，有关页树的描述见7.6
        /// </summary>
        [Required]
        [XmlArrayItem("Page")]
        public List<PageTree> Pages { get; set; }
        /// <summary>
        /// 大纲，有关大纲的描述见7.8
        /// </summary>
        public List<Outline> Outlines { get; set; }
        /// <summary>
        /// 文档的权限声明
        /// </summary>
        public Permission Permissions { get; set; }
        /// <summary>
        /// 文档关联的动作序列，当存在多个 <see cref="Action"/> 对象时，所有动作依次执行
        /// </summary>
        [Required]
        public List<Action> Actions { get; set; }
        /// <summary>
        /// 文档的视图首选项
        /// </summary>
        public VPreferences VPreferences { get; set; }
        /// <summary>
        /// 文档的书签集，包含一组书签
        /// </summary>
        public List<Bookmark> Bookmarks { get; set; }
        /// <summary>
        /// 指向附件列表文件。有关附件描述见第20章
        /// </summary>
        public Location Attachments { get; set; }
        /// <summary>
        /// 指向注释列表文件，有关注释描述见第15章
        /// </summary>
        public Location Annotations { get; set; }
        /// <summary>
        /// 指向自定义标引列表文件，有关自定义标引描述见第16章
        /// </summary>
        public Location CustomTags { get; set; }
        /// <summary>
        /// 指向扩展列表文件，有关扩展描述见第17章
        /// </summary>
        public Location Extensions { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}