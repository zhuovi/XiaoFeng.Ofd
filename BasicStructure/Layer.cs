using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.BaseType;
using XiaoFeng.Ofd.Enum;
using XiaoFeng.Xml;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 20:07:55                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.BasicStructure
{
    /// <summary>
    /// <para>图层</para>
    /// <para>详情说明 见图 <see langword="15"/> ，见表 <see langword="14"/> </para>
    /// </summary>
    public class Layer : IPageBlock
    {
        #region 构造器
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        public Layer()
        {
            this.PageBlock = new List<IPageBlock>();
        }
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="type">层描述类型</param>
        /// <param name="drawParam">图层的绘制参数</param>
        /// <param name="pageBlock">页面块</param>
        public Layer(STID id, LayerType type, STRefID drawParam, List<IPageBlock> pageBlock = null)
        {
            this.ID = id;
            Type = type;
            DrawParam = drawParam;
            if (pageBlock != null) PageBlock = pageBlock;
        }
        #endregion

        #region 属性
        /// <summary>
        /// ID
        /// </summary>
        [XmlAttribute]
        public STID ID { get; set; }
        /// <summary>
        /// 层描述类型
        /// </summary>
        [XmlAttribute]
        [XmlConverter(typeof(StringEnumConverter))]
        public LayerType Type { get; set; } = LayerType.Body;
        /// <summary>
        /// 图层的绘制参数，引用资源文件中定义的绘制参数标识
        /// </summary>
        [XmlAttribute]
        public STRefID DrawParam { get; set; }
        /// <summary>
        /// 页面块
        /// </summary>
        
        public List<IPageBlock> PageBlock { get; set; }
        #endregion

        #region 方法
        /// <summary>
        /// 添加页面块
        /// </summary>
        /// <param name="pageBlock">页面块</param>
        public void AddPageBlock(IPageBlock pageBlock)
        {
            if (pageBlock == null) return;
            if (this.PageBlock == null) this.PageBlock = new List<IPageBlock>();
            this.PageBlock.Add(pageBlock);
        }
        #endregion
    }
}