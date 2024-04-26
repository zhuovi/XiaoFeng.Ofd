using System;
using System.Collections.Generic;
using System.Text;
using XiaoFeng.Ofd.Enum;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 19:28:19                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.BasicStructure
{
    /// <summary>
    /// <para>文档视图首选项</para>
    /// <para>详情说明 见图 <see langword="10"/> ，见表 <see langword="9"/> </para>
    /// </summary>
    public class VPreferences
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public VPreferences()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 窗口模式
        /// </summary>
        public PageMode PageMode { get; set; }
        /// <summary>
        /// 页面布局模式
        /// </summary>
        public PageLayout PageLayout { get; set; } = PageLayout.OneColumn;
        /// <summary>
        /// 标题栏显示模式
        /// </summary>
        public TabDisplay TabDisplay { get; set; } = TabDisplay.DocTitle;
        /// <summary>
        /// 是否隐藏工具栏
        /// </summary>
        public bool HideToolbar { get; set; }
        /// <summary>
        /// 是否隐藏菜单栏
        /// </summary>
        public bool HideMenubar { get; set; }
        /// <summary>
        /// 是否隐藏主窗口之外的其它窗口组件
        /// </summary>
        public bool HideWindowUI { get; set; }
        /// <summary>
        /// 自动缩放模式
        /// </summary>
        public ZoomMode ZoomMode { get; set; }
        /// <summary>
        /// 文档绽放率
        /// </summary>
        public double Zoom { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}