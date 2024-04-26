using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using XiaoFeng.Ofd.BaseType;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-04-23 08:59:24                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Internal
{
    /// <summary>
    /// 矩形区域
    /// </summary>
    public class Rectangle : IEquatable<Rectangle>
    {
        #region 构造器
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        public Rectangle() { }
        /// <summary>
        /// 设置矩形区域
        /// </summary>
        /// <param name="x">X坐标</param>
        /// <param name="y">Y坐标</param>
        /// <param name="width">宽</param>
        /// <param name="height">高</param>
        public Rectangle(float x, float y, float width, float height)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }
        public Rectangle(PointF point, SizeF size)
        {
            this.Location = point;
            this.Size = size;
        }
        #endregion

        #region 属性
        /// <summary>
        /// X坐标
        /// </summary>
        public float X { get; set; }
        /// <summary>
        /// Y坐标
        /// </summary>
        public float Y { get; set; }
        /// <summary>
        /// 宽
        /// </summary>
        public float Width { get; set; }
        /// <summary>
        /// 高
        /// </summary>
        public float Height { get; set; }
        /// <summary>
        /// 左边开始坐标
        /// </summary>
        public float Left => this.X;
        /// <summary>
        /// 上边开始坐标
        /// </summary>
        public float Top => this.Y;
        /// <summary>
        /// 右边坐标
        /// </summary>
        public float Right => this.X + this.Width;
        /// <summary>
        /// 底部坐标
        /// </summary>
        public float Bottom => this.Y + this.Height;
        /// <summary>
        /// 是否为空矩形
        /// </summary>
        public bool IsEmpty => this.Width <= 0 || this.Height <= 0;
        /// <summary>
        /// 获取或设置此 <see cref="Rectangle"/> 矩形区域的左上角的坐标
        /// </summary>
        public PointF Location
        {
            get => new PointF(X, Y);
            set
            {
                this.X = value.X;
                this.Y = value.Y;
            }
        }
        /// <summary>
        /// 获取或设置此 <see cref="Rectangle"/> 矩形区域的 宽和高。
        /// </summary>
        public SizeF Size
        {
            get => new SizeF(this.Width, this.Height);
            set
            {
                this.Width = value.Width;
                this.Height = value.Height;
            }
        }
        /// <summary>
        /// 空矩形
        /// </summary>
        public static Rectangle Empty => new Rectangle(0, 0, 0, 0);
        #endregion

        #region 方法
        /// <summary>
        /// 复制出一个新实例
        /// </summary>
        /// <returns></returns>
        public Rectangle Clone() => new Rectangle(this.X, this.Y, this.Width, this.Height);
        /// <summary>
        /// 确定此矩形是否与 <paramref name="rect"/> 相交。
        /// </summary>
        /// <param name="rect">矩形对象</param>
        /// <returns></returns>
        public bool IntersectsWith(Rectangle rect) => (rect.X < X + this.Width) && (X < rect.X + rect.Width) && (rect.Y < Y + this.Height) && (Y < rect.Y + rect.Height);
        /// <summary>
        /// 指定的坐标点是否包含在 <see cref="Rectangle"/> 矩形中。
        /// </summary>
        /// <param name="x">横向坐标</param>
        /// <param name="y">纵向坐标</param>
        /// <returns></returns>
        public bool Contains(double x, double y) => this.X <= x && this.X + this.Width > x && this.Y >= y && this.Y + Height > y;
        /// <summary>
        /// 指定的坐标点是否包含在 <see cref="Rectangle"/> 矩形中。
        /// </summary>
        /// <param name="p">坐标点</param>
        /// <returns></returns>
        public bool Contains(PointF p) => this.Contains(p.X, p.Y);
        /// <summary>
        /// 指定的矩形是否包含在 <see cref="Rectangle"/> 矩形中。
        /// </summary>
        /// <param name="rect">一个 <see cref="Rectangle"/> 矩形。</param>
        /// <returns></returns>
        public bool Contains(Rectangle rect) => this.X <= rect.X && rect.X + rect.Width <= this.X + this.Width && this.Y <= rect.Y && rect.Y + rect.Height <= this.Y + this.Height;
        /// <summary>
        /// 将此矩形的位置调整指定的量。
        /// </summary>
        /// <param name="x">水平偏移量。</param>
        /// <param name="y">垂直偏移量。</param>
        public void Offset(float x, float y)
        {
            this.X += x;
            this.Y += y;
        }
        /// <summary>
        /// 将此矩形的位置调整指定的量
        /// </summary>
        /// <param name="p">坐标点</param>
        public void Offset(PointF p)
        {
            this.Offset(p.X, p.Y);
        }
        /// <summary>
        /// 将此矩形的位置调整指定的量
        /// </summary>
        /// <param name="s">大小</param>
        public void Offset(SizeF s)
        {
            this.Offset(s.Width, s.Height);
        }
        ///<inheritdoc/>
        public override int GetHashCode()
        {
            return HashCode.Combine(this.X, this.Y, this.Width, this.Height);
        }
        ///<inheritdoc/>
        public override string ToString()
        {
            return $"[Rectangle]:{this.ToJson()}";
        }
        ///<inheritdoc/>
        public bool Equals(Rectangle other)
        {
            return this == other;
        }
        ///<inheritdoc/>
        public override bool Equals(object obj)
        {
            return obj is Rectangle rect && Equals(rect);
        }
        /// <summary>
        /// 测试两个 <see cref="Rectangle"/> 结构的位置和大小是否相同。
        /// </summary>
        /// <param name="left">相等运算符左侧的<see cref="Rectangle"/> 结构。</param>
        /// <param name="right">相等运算符右侧的<see cref="Rectangle"/> 结构。</param>
        /// <returns></returns>
        public static bool operator ==(Rectangle left, Rectangle right)
        {
            return left.X == right.X && left.Y == right.Y && left.Width == right.Width && left.Height == right.Height;
        }
        /// <summary>
        /// 测试两个 <see cref="Rectangle"/> 结构的位置或大小是否不同。
        /// </summary>
        /// <param name="left">不等运算符左侧的<see cref="Rectangle"/> 结构。</param>
        /// <param name="right">不等运算符右侧的<see cref="Rectangle"/> 结构。</param>
        /// <returns></returns>
        public static bool operator !=(Rectangle left, Rectangle right)
        {
            return left.X != right.X || left.Y != right.Y || left.Width != right.Width || left.Height != right.Height;
        }
        /// <summary>
        /// 给当前 <see cref="Rectangle"/> 矩形移动坐标位置
        /// </summary>
        /// <param name="left">当前  <see cref="Rectangle"/> 。</param>
        /// <param name="point">坐标点 <see cref="PointF"/> 。</param>
        /// <returns></returns>
        public static Rectangle operator +(Rectangle left, PointF point)
        {
            return new Rectangle(left.X + point.X, left.Y + point.Y, left.Width, left.Height);
        }
        /// <summary>
        /// 给当前 <see cref="Rectangle"/> 矩形移动坐标位置
        /// </summary>
        /// <param name="left">当前  <see cref="Rectangle"/> 。</param>
        /// <param name="point">坐标点 <see cref="PointF"/> 。</param>
        /// <returns></returns>
        public static Rectangle operator -(Rectangle left, PointF point)
        {
            return new Rectangle(left.X - point.X, left.Y - point.Y, left.Width, left.Height);
        }
        /// <summary>
        /// 给当前 <see cref="Rectangle"/> 矩形扩大宽高。
        /// </summary>
        /// <param name="left">当前  <see cref="Rectangle"/> 。</param>
        /// <param name="size">宽高 <see cref="SizeF"/> 。</param>
        /// <returns></returns>
        public static Rectangle operator +(Rectangle left, SizeF size)
        {
            return new Rectangle(left.X, left.Y, left.Width + size.Width, left.Height + size.Height);
        }
        /// <summary>
        /// 给当前 <see cref="Rectangle"/> 矩形缩小宽高。
        /// </summary>
        /// <param name="left">当前  <see cref="Rectangle"/> 。</param>
        /// <param name="size">宽高 <see cref="SizeF"/> 。</param>
        /// <returns></returns>
        public static Rectangle operator -(Rectangle left, SizeF size)
        {
            return new Rectangle(left.X, left.Y, left.Width - size.Width, left.Height - size.Height);
        }
        /// <summary>
        /// 与对象 <paramref name="rect"/> 之间的并集。
        /// </summary>
        /// <param name="rect">一个 <see cref="Rectangle"/> 矩形。</param>
        public void Union(Rectangle rect)
        {
            var result = Union(rect, this);
            this.X = result.X;
            this.Y = result.Y;
            this.Width = result.Width;
            this.Height = result.Height;
        }
        /// <summary>
        /// 与对象 <paramref name="rect"/> 之前的交点。
        /// </summary>
        /// <param name="rect">一个 <see cref="Rectangle"/> 矩形。</param>
        public void Intersect(Rectangle rect)
        {
            var result = Intersect(rect, this);
            this.X = result.X;
            this.Y = result.Y;
            this.Width = result.Width;
            this.Height = result.Height;
        }
        /// <summary>
        /// 创建一个矩形，表示 <paramref name="a"/> 和 <paramref name="b"/> 之间有交点，如果没有交点，则返回空矩形
        /// </summary>
        /// <param name="a">一个 <see cref="Rectangle"/> 矩形。</param>
        /// <param name="b">一个 <see cref="Rectangle"/> 矩形。</param>
        /// <returns></returns>
        public static Rectangle Intersect(Rectangle a, Rectangle b)
        {
            var x1 = Math.Max(a.X, b.X);
            var x2 = Math.Min(a.X + a.Width, b.X + b.Width);
            var y1 = Math.Max(a.Y, b.Y);
            var y2 = Math.Min(a.Y + a.Height, b.Y + b.Height);
            if (x2 >= x1 && y2 >= y1)
                return new Rectangle(x1, y1, x2 - x1, y2 - y1);
            return Empty;
        }
        /// <summary>
        /// 创建一个矩形，表示 <paramref name="a"/> 和 <paramref name="b"/> 之间的并集。
        /// </summary>
        /// <param name="a">一个 <see cref="Rectangle"/> 矩形。</param>
        /// <param name="b">一个 <see cref="Rectangle"/> 矩形。</param>
        /// <returns></returns>
        public static Rectangle Union(Rectangle a, Rectangle b)
        {
            var x1 = Math.Min(a.X, b.X);
            var x2 = Math.Max(a.X + a.Width, b.X + b.Width);
            var y1 = Math.Min(a.Y, b.Y);
            var y2 = Math.Max(a.Y + a.Height, b.Y + b.Height);
            return new Rectangle(x1, y1, x2 - x1, y2 - y1);
        }
        /// <summary>
        /// 强制转换为 <see cref="Rectangle"/> 对象
        /// </summary>
        /// <param name="box">矩形区域</param>
        public static explicit operator Rectangle(Box box)
        {
            return new Rectangle(box.X, box.Y, box.Width, box.Height);
        }
        /// <summary>
        /// 强制转换为矩形区域 <see cref="Box"/> 对象
        /// </summary>
        /// <param name="rect">矩形区域</param>
        public static implicit operator Box(Rectangle rect)
        {
            return new Box(rect.X, rect.Y, rect.Width, rect.Height);
        }
        #endregion
    }
}