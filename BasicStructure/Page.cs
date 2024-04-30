using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
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
*  Create Time : 2024-03-26 19:22:07                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.BasicStructure
{
    /// <summary>
    /// <para>页对象</para>
    /// <para>页对象支持模板页描述，每一页经常需要重复显示的内容可统一在模板页中描述，文档可以包含多个模板页。通过使用模板页可以使重复显示的内容不必出现在描述每一页的页面描述内容中.而只需通过Templnte节点进行引用</para>
    /// <para>详情说明 见图 <see langword="13"/> ，见表 <see langword="12"/> </para>
    /// </summary>
    [XmlPath("Doc_{0}/Pages/Page_{1}/Content.xml")]
    public class Page:XmlEntity<Page>
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Page()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 该页所使用的模板页。模板页的内容结构和普通页相同，定义在 <see cref="CommonData"/> 指定的XML文件中。一个页可以使用多个模板页。该节点使用时通过TemplateID来引用具体的模板，并通用 <see cref="PageTemplate.ZOrder"/> 属性来控制模板在页面中的呈现顺序，注：在模板页的内容描述中该属性无效
        /// </summary>
        public List<PageTemplate> Template { get; set; }
        /// <summary>
        /// 定义该页面面区域的大小和位置，仅对该页有效。该节点不出现时则使用模板页中的定义，如果模板页不存在或模板页中没有定义页面区域，则使用文件 <see cref="CommonData"/> 中的定义
        /// </summary>
        public PageArea Area { get; set; }
        /// <summary>
        /// 页资源，指向该页使用的资源文件
        /// </summary>
        public Location PageRes { get; set; }
        /// <summary>
        /// 页面内容描述，该节点不存在时，表示空白页
        /// </summary>
        public List<Layer> Content { get; set; }
        /// <summary>
        /// 与页面关联的动作序列。当存在多个 <see cref="Action"/> 对象时，所有动作依次执行
        /// </summary>
        public List<Action> Actions { get; set; }
        #endregion

        #region 方法
        /// <summary>
        /// 添加图层
        /// </summary>
        /// <param name="layer">图层</param>
        public void AddLayer(Layer layer)
        {
            if (this.Content == null) this.Content = new List<Layer>();
            this.Content.Add(layer);
        }
        /// <summary>
        /// 移除图层
        /// </summary>
        /// <param name="index">图层索引</param>
        public void RemoveLayer(int index)
        {
            if (this.Content == null || this.Content.Count == 0 || this.Content.Count <= index) return;
            this.Content.RemoveAt(index);
        }
        #endregion
    }
}