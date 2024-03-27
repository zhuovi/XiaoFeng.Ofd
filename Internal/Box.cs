using System;
using System.Collections.Generic;
using System.Text;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 17:47:54                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Internal
{
    /// <summary>
    /// 矩形区域
    /// </summary>
    public class Box : IEquatable<Box>
    {
        #region 构造器
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        public Box()
        {

        }
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="left">矩形左坐标</param>
        /// <param name="top">矩形上坐标</param>
        /// <param name="width">矩形宽</param>
        /// <param name="height">矩形高</param>
        public Box(float left, float top, float width, float height)
        {
            Left = left;
            Top = top;
            Width = width;
            Height = height;
        }
        /// <summary>
        /// 矩形
        /// </summary>
        /// <param name="val">矩形字符串 "矩形左坐标 矩形上坐标 矩形宽 矩形高" 如 "0 0 100 120"</param>
        public Box(string val)
        {
            if (val.IsNullOrEmpty()) return;
            var vals = val.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (vals.Length != 4) return;
            this.Left = vals.ToCast<float>();
            this.Top = vals.ToCast<float>();
            this.Width = vals.ToCast<float>();
            if (this.Width < 0) this.Width = 0;
            this.Height = vals.ToCast<float>();
            if (this.Height < 0) this.Height = 0;
        }
        #endregion

        #region 属性
        /// <summary>
        /// 矩形左坐标
        /// </summary>
        public float Left { get; set; }
        /// <summary>
        /// 矩形上坐标
        /// </summary>
        public float Top { get; set; }
        /// <summary>
        /// 矩形宽
        /// </summary>
        public float Width { get; set; }
        /// <summary>
        /// 矩形高
        /// </summary>
        public float Height { get; set; }
        #endregion

        #region 方法
        ///<inheritdoc/>
        public override string ToString()
        {
            return $"{this.Left} {this.Top} {this.Width} {this.Height}";
        }
        ///<inheritdoc/>
        public bool Equals(Box other)
        {
            return this.Top == other.Top && this.Left == other.Left && this.Width == other.Width && this.Height == other.Height;
        }
        /// <summary>
        /// 显示转换
        /// </summary>
        /// <param name="v">值</param>
        public static explicit operator string(Box v)
        {
            return v.ToString();
        }
        /// <summary>
        /// 隐式转换
        /// </summary>
        /// <param name="v">值</param>
        public static implicit operator Box(string v)
        {
            return new Box(v);
        }
        #endregion
    }
}