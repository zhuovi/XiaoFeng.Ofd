using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Attributes;
using XiaoFeng.Ofd.BaseType;
using XiaoFeng.Ofd.Enum;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 17:15:42                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.BasicStructure
{
    /// <summary>
    /// <para>文件公共数据</para>
    /// <para>详情说明 见图 <see langword="6"/> ，见表 <see langword="6"/> </para>
    /// </summary>
    public class CommonData
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public CommonData()
        {
            this.MaxUnitID = 1U;
        }
        #endregion

        #region 属性
        /// <summary>
        /// 当前文档中所有对象使用标识的最大值，初始值为0。MaxUnitID主要用于文档编辑，在向文档中新增加一个对象时，需要分配一个新的标识 ，新的标识取值宜为MaxUnitID+1,同时需要修改此MaxUnitID值
        /// </summary>
        [Required]
        public STID MaxUnitID { get; set; }
        /// <summary>
        /// 指定该文档页面区域的默认大小和位置
        /// </summary>
        [Required]
        public PageArea PageArea { get; set; }
        /// <summary>
        /// 公共资源序列，每个节点指向OFD包内一个资源描述文档，资源部分的描述见7.9，字体和颜色空间等宜在公共资源文件中描述
        /// </summary>
        public Location PublicRes { get; set; } = new Location("PublicRes.xml");
        /// <summary>
        /// 文档资源序列，每个节点指向OFD包内一个资源描述文档，资源部分的描述见7.9，绘制参数、多媒体和矢量图像等宜在文档资源文件中描述  
        /// </summary>
        public Location DocumentRes { get; set; } = new Location("DocumentRes.xml");
        /// <summary>
        /// 模板页序列，为一系列模板页的集合，模板页内容结构和普通 页相同，描述见7.7
        /// </summary>
        [XmlArrayItem("TemplatePage")]
        public List<TemplatePage> TemplatePage { get; set; }
        /// <summary>
        /// 引用在资源文件中定义的颜色空间标识，有关颜色空间的描述见8.3.1。如果此贡不存在，采用RGB作为默认颜色空间
        /// </summary>
        public STRefID DefaultCS { get; set; }
        #endregion

        #region 方法
        /// <summary>
        /// 获取最大ID并自动加一并返回
        /// </summary>
        /// <returns></returns>
        public STID GetMaxUnitIDAndAdd()
        {
            return ++this.MaxUnitID;
        }
        /// <summary>
        /// 添加模板页
        /// </summary>
        /// <param name="page">模板页</param>
        public void AddTemplatePage(TemplatePage page)
        {
            if (page == null) return;
            if (this.TemplatePage == null) this.TemplatePage = new List<TemplatePage>();
            this.TemplatePage.Add(page);
        }
        /// <summary>
        /// 添加模板页
        /// </summary>
        /// <param name="id">模板页的标识</param>
        /// <param name="baseLoc">指向模板页内容描述文件</param>
        /// <param name="name">模板页名称</param>
        /// <param name="zOrder">模板页的默认图层类型</param>
        public void AddTemplatePage(STID id, Location baseLoc, string name = "", LayerType zOrder = LayerType.Background)
        {
            this.AddTemplatePage(new TemplatePage(id, baseLoc, name, zOrder));
        }
        /// <summary>
        /// 添加模板页
        /// </summary>
        /// <param name="id">模板页的标识</param>
        /// <param name="baseLoc">指向模板页内容描述文件</param>
        /// <param name="name">模板页名称</param>
        /// <param name="zOrder">模板页的默认图层类型</param>
        public void AddTemplatePage(uint id, string baseLoc, string name = "", LayerType zOrder = LayerType.Background)
        {
            this.AddTemplatePage((STID)id, (Location)baseLoc, name, zOrder);
        }
        /// <summary>
        /// 添加模板页
        /// </summary>
        /// <param name="name">模板页名称</param>
        /// <param name="zOrder">层排序</param>
        public void AddTemplatePage(string name = "", LayerType zOrder = LayerType.Background)
        {
            this.AddTemplatePage(this.GetMaxUnitIDAndAdd(), $"Tpls/Tpls_{this.TemplatePage?.Count}/Content.xml", name, zOrder);
        }
        /// <summary>
        /// 移除模板页
        /// </summary>
        /// <param name="index">模板页索引</param>
        internal void RemoveTemplatePage(int index)
        {
            if (this.TemplatePage == null || this.TemplatePage.Count == 0 || this.TemplatePage.Count <= index) return;
            this.TemplatePage.RemoveAt(index);
            for (var i = index; i < this.TemplatePage.Count; i++)
            {
                this.TemplatePage[i].BaseLoc = $"Tpls/Tpl_{i}/Content.xml";
            }
        }
        #endregion
    }
}