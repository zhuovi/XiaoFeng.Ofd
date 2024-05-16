using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Actions;
using XiaoFeng.Ofd.Attributes;
using XiaoFeng.Ofd.BaseType;
using XiaoFeng.Ofd.Internal;
using Action = XiaoFeng.Ofd.Actions.Action;

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
namespace XiaoFeng.Ofd.BasicStructure
{
    /// <summary>
    /// <para>文档根节点</para>
    /// <para>详情说明 见图 <see langword="5"/> ，见表 <see langword="5"/> </para>
    /// </summary>
    [XmlPath("Doc_{0}/Document.xml")]
    public class Document : XmlEntity<Document>
    {
        #region 构造器
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        public Document()
        {
            this.CommonData = new List<CommonData>();
            this.Pages = new List<PageTree>();
            this.Outlines = new List<OutlineElem>();
            this.Bookmarks = new List<Bookmark>();
        }
        #endregion

        #region 属性
        /// <summary>
        /// 文档公共数据，定义了页面区域、公共资源等数据
        /// </summary>
        [Required]
        [XmlArrayItem("CommonData")]
        public List<CommonData> CommonData { get; set; }
        /// <summary>
        /// 页树，有关页树的描述见7.6
        /// </summary>
        [Required]
        [XmlArrayItem("Page")]
        [XmlArray("Pages")]
        public List<PageTree> Pages { get; set; }
        /// <summary>
        /// 大纲，有关大纲的描述见7.8
        /// </summary>
        public List<OutlineElem> Outlines { get; set; }
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
        /// <summary>
        /// 添加文件公共数据
        /// </summary>
        /// <param name="data">文件公共数据</param>
        public void AddCommonData(CommonData data)
        {
            if (data == null) return;
            if (this.CommonData == null) this.CommonData = new List<CommonData>();
            this.CommonData.Add(data);
        }
        /// <summary>
        /// 设置最大对象ID
        /// </summary>
        /// <param name="maxUnitID">最大对象ID</param>
        public void SetMaxUnitID(uint maxUnitID)
        {
            if (this.CommonData == null) this.CommonData = new List<CommonData>();
            this.CommonData.Each(c =>
            {
                c.MaxUnitID = maxUnitID;
            });
        }
        /// <summary>
        /// 最大对象ID自动加一
        /// </summary>
        public void AddMaxUnitID()
        {
            this.GetMaxUnitIDAndAdd();
        }
        /// <summary>
        /// 获取最大对象ID
        /// </summary>
        /// <returns></returns>
        public STID GetMaxUnitID()
        {
            if (this.CommonData == null || this.CommonData.Count == 0) return 0;
            return this.CommonData.FirstOrDefault().MaxUnitID;
        }
        /// <summary>
        /// 获取最大对象ID并在最大对象ID自动加一
        /// </summary>
        /// <returns></returns>
        public STID GetMaxUnitIDAndAdd()
        {
            if (this.CommonData == null) this.CommonData = new List<CommonData>();
            var maxID = 0U;
            this.CommonData.Each(c =>
            {
                c.MaxUnitID++;
                maxID = Math.Max(maxID, (uint)c.MaxUnitID);
            });
            return maxID;
        }
        /// <summary>
        /// 添加页树
        /// </summary>
        /// <param name="pageTree">页树</param>
        internal void AddPageTree(PageTree pageTree)
        {
            if (this.Pages == null) this.Pages = new List<PageTree>();
            this.Pages.Add(pageTree);
        }
        /// <summary>
        /// 添加页树
        /// </summary>
        internal void AddPageTree()
        {
            this.AddPageTree(new PageTree((uint)this.GetMaxUnitIDAndAdd(), (uint)this.Pages.Count));
        }
        /// <summary>
        /// 移除页面
        /// </summary>
        /// <param name="index">页数索引</param>
        internal void RemovePageTree(int index)
        {
            if (this.Pages == null || this.Pages.Count == 0 || this.Pages.Count <= index) return;
            this.Pages.RemoveAt(index);
            for (var i = index; i < this.Pages.Count; i++)
            {
                this.Pages[i].BaseLoc = $"Pages/Page_{i}/Content.xml";
            }
        }
        #endregion
    }
}