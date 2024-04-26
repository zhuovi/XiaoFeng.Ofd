using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XiaoFeng.Ofd.BaseType;
using XiaoFeng.Ofd.BasicStructure;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-04-24 14:27:09                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Internal
{
    /// <summary>
    /// 文档结构
    /// </summary>
    public class DocumentStructure
    {
        #region 构造器
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        public DocumentStructure()
        {
            this.Document = new Document();
            this.DocumentRes = new DocumentRes();
            this.PublicRes = new PublicRes();
            this.Pages = new List<Page>();
        }
        #endregion

        #region 属性
        /// <summary>
        /// 文档
        /// </summary>
        public Document Document { get; set; }
        /// <summary>
        /// 文档资源
        /// </summary>
        public DocumentRes DocumentRes { get; set; }
        /// <summary>
        /// 公共资源
        /// </summary>
        public PublicRes PublicRes { get; set; }
        /// <summary>
        /// 页面集合
        /// </summary>
        public List<Page> Pages { get; set; }
        #endregion

        #region 方法
        /// <summary>
        /// 添加页面
        /// </summary>
        /// <param name="page">页面</param>
        public void AddPage(Page page)
        {
            if (this.Pages == null) this.Pages = new List<Page>();
            this.Pages.Add(page);
            this.Document.AddPageTree(new PageTree
            {
                ID = this.Document.GetMaxUnitIDAndAdd(),
                BaseLoc = new Location($"Pages/Page_{this.Pages.Count - 1}/Content.xml")
            });
        }
        /// <summary>
        /// 移除页面
        /// </summary>
        /// <param name="index">页面索引</param>
        public void RemovePage(int index)
        {
            if (this.Pages == null || this.Pages.Count == 0 || this.Pages.Count <= index) return;
            this.Pages.RemoveAt(index);
            this.Document.RemovePageTree(index);
        }
        /// <summary>
        /// 获取页面
        /// </summary>
        /// <param name="index">页面索引</param>
        /// <returns></returns>
        public Page GetPage(int index)
        {
            if (this.Pages == null || this.Pages.Count == 0 || this.Pages.Count <= index) return null;
            return this.Pages[index];
        }
        #endregion
    }
}