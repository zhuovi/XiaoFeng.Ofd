using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Attributes;
using XiaoFeng.Ofd.Enum;
using XiaoFeng.Ofd.Graph;
using XiaoFeng.Xml;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 19:26:03                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Actions
{
    /// <summary>
    /// <para>动作类型</para>
    /// <para>详情说明 见图 <see langword="73"/> ，见表 <see langword="51"/> </para>
    /// </summary>
    public class Action
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Action()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 事件类型，触发动作的条件，事件的具体类型见表52
        /// </summary>
        [XmlAttribute]
        [Required]
        [XmlConverter(typeof(StringEnumConverter))]
        public ActionEvent Event { get; set; }
        /// <summary>
        /// 指定多个复杂区域为该链接对象的启动区域，不出现时以所在图元或页面的外接矩形作为启动区域
        /// </summary>
        public Region Region { get; set; }
        /// <summary>
        /// 本文档内的跳转
        /// </summary>
        public Goto Goto { get; set; }
        /// <summary>
        /// 打开或访问一个 <see cref="URI"/> 链接
        /// </summary>
        public URI URI { get; set; }
        /// <summary>
        /// 打开本文档附件
        /// </summary>
        public GotoA GotoA { get; set; }
        /// <summary>
        /// 播放一段音频
        /// </summary>
        public Sound Sound { get; set; }
        /// <summary>
        /// 播放一段视频
        /// </summary>
        public Movie Movie { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}