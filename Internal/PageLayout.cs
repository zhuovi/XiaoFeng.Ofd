using System;
using System.Collections.Generic;
using System.Text;
using XiaoFeng.Ofd.BaseType;
using XiaoFeng.Ofd.BasicStructure;
using XiaoFeng.Ofd.Enum;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-04-23 08:56:33                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Internal
{
    /// <summary>
    /// 页面配置
    /// </summary>
    public class PageLayout
    {
        #region 构造器
        /// <summary>
        /// 初始化一个新的实例
        /// </summary>
        public PageLayout() { }
        /// <summary>
        /// 初始化一个新的实例
        /// </summary>
        /// <param name="width">宽</param>
        /// <param name="height">高</param>
        public PageLayout(float width, float height)
        {
            this.Width = width;
            this.Height = height;
        }
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="box">矩形区域</param>
        public PageLayout(Box box)
        {
            if (box == null) return;
            this.Width = box.Width;
            this.Height = box.Height;
            this.MarginTop = box.Top;
            this.MarginLeft = box.Left;
            this.MarginRight = box.Right;
            this.MarginBottom = box.Bottom;
        }
        #endregion

        #region 属性
        /// <summary>
        /// 宽
        /// </summary>
        public float Width { get; set; }
        /// <summary>
        /// 高
        /// </summary>
        public float Height { get; set; }
        /// <summary>
        /// 上边距
        /// </summary>
        public float MarginTop { get; set; } = 25.4f;
        /// <summary>
        /// 左边距
        /// </summary>
        public float MarginLeft { get; set; } = 31.7f;
        /// <summary>
        /// 下边距
        /// </summary>
        public float MarginBottom { get; set; } = 25.4f;
        /// <summary>
        /// 右边距
        /// </summary>
        public float MarginRight { get; set; } = 31.7f;
        /// <summary>
        /// A0
        /// </summary>
        public static PageLayout A0 => new PageLayout(841f, 1189f);
        /// <summary>
        /// A1
        /// </summary>
        public static PageLayout A1 => new PageLayout(594f, 841f);
        /// <summary>
        /// A2
        /// </summary>
        public static PageLayout A2 => new PageLayout(420f,594f);
        /// <summary>
        /// A3
        /// </summary>
        public static PageLayout A3 => new PageLayout(297f,420f);
        /// <summary>
        /// A4
        /// </summary>
        public static PageLayout A4 => new PageLayout(210f, 297f);
        /// <summary>
        /// A5
        /// </summary>
        public static PageLayout A5 => new PageLayout(148f, 210f);
        /// <summary>
        /// A6
        /// </summary>
        public static PageLayout A6 => new PageLayout(105f, 148f);
        /// <summary>
        /// A7
        /// </summary>
        public static PageLayout A7 => new PageLayout(74f, 105f);
        /// <summary>
        /// A8
        /// </summary>
        public static PageLayout A8 => new PageLayout(52f, 74f);
        /// <summary>
        /// A9
        /// </summary>
        public static PageLayout A9 => new PageLayout(37f, 52f);
        /// <summary>
        /// A10
        /// </summary>
        public static PageLayout A10 => new PageLayout(26f, 37f);
        #endregion

        #region 方法
        /// <summary>
        /// 获取区域
        /// </summary>
        /// <returns></returns>
        public PageArea GetPageArea()
        {
            return new PageArea()
            {
                PhysicalBox = new Box(this.MarginLeft, this.MarginTop, this.Width, this.Height),
            };
        }
        ///<inheritdoc/>
        public override string ToString()
        {
            return $"{{width:{this.Width},height:{this.Height},top:{this.MarginTop},left:{this.MarginLeft},bottom:{this.MarginBottom},right:{this.MarginRight}}}";
        }
        /// <summary>
        /// 强制转换
        /// </summary>
        /// <param name="box">矩形区域</param>
        public static explicit operator PageLayout(Box box)
        {
            return box == null ? null : new PageLayout(box);
        }
        /// <summary>
        /// 强制转换
        /// </summary>
        /// <param name="pageLayout">页面配置</param>
        public static explicit operator Box(PageLayout pageLayout)
        {
            return pageLayout == null ? null : new Box(pageLayout.MarginLeft, pageLayout.MarginTop, pageLayout.Width, pageLayout.Height);
        }
        #endregion
    }
}