using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Actions;
using XiaoFeng.Ofd.Attributes;
using Action = XiaoFeng.Ofd.Actions.Action;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 20:27:03                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.BasicStructure
{
    /// <summary>
    /// <para>大纲根节点</para>
    /// <para>详情说明 见图 <see langword="19"/> ，见表 <see langword="17"/> </para>
    /// </summary>
    public class OutlineElem
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public OutlineElem()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 大纲节点标题
        /// </summary>
        [XmlAttribute]
        [Required]
        public string Title { get; set; }
        /// <summary>
        /// 该节点下所有的叶节点的数目参考值，应根据该节点下实际 出现的子节点数为准,默认为0
        /// </summary>
        [XmlAttribute]
        public int Count { get; set; }
        /// <summary>
        /// 在有子节点存在时有效，如果为 true ,表示该大纲在初始状态下展开子节点；如果为false，则表示不展示 ，默认为true
        /// </summary>
        [XmlAttribute]
        public bool Expanded { get; set; } = true;
        /// <summary>
        /// 当此大纲节点被激活时将执行的动作序列
        /// </summary>
        public List<Action> Actions { get; set; }
        /// <summary>
        /// 该节点的子大纲节点。层层嵌套，形成树状结构
        /// </summary>
        [XmlElement("OutlineElem")]
        public OutlineElem OutlineElement { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}