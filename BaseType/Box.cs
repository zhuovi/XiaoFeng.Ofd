using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Internal;
using XiaoFeng.Xml;

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
namespace XiaoFeng.Ofd.BaseType
{
    /// <summary>
    /// 矩形区域
    /// </summary>
    public class Box : IEquatable<Box>,IValue
    {
        #region 构造器
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        public Box() { }
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
        /// 初始化一个新实例
        /// </summary>
        /// <param name="point">坐标点</param>
        /// <param name="size">大小</param>
        public Box(PointF point, SizeF size)
        {
            this.Location = point;
            this.Size = size;
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
            Left = vals[0].ToCast<float>();
            Top = vals[1].ToCast<float>();
            Width = vals[2].ToCast<float>();
            if (Width < 0) Width = 0;
            Height = vals[3].ToCast<float>();
            if (Height < 0) Height = 0;
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
        /// <summary>
        /// 横向位置
        /// </summary>
        [XmlConverter(typeof(XmlIgnoreAttribute))]
        public float X
        {
            get => this.Left;
            set => this.X = value;
        }
        /// <summary>
        /// 纵向位置
        /// </summary>
        [XmlConverter(typeof(XmlIgnoreAttribute))]
        public float Y
        {
            get => this.Top;
            set => this.Top = value;
        }
        /// <summary>
        /// 右边位置
        /// </summary>
        public float Right => this.Left + this.Width;
        /// <summary>
        /// 下边位置
        /// </summary>
        public float Bottom => this.Top + this.Height;
        /// <summary>
        /// 是否为空矩形区域
        /// </summary>
        public bool IsEmpty => this.Width <= 0 || this.Height <= 0;
        /// <summary>
        /// 获取或设置此 <see cref="Box"/> 矩形区域的左上角的坐标
        /// </summary>
        [XmlConverter(typeof(XmlIgnoreAttribute))]
        public PointF Location
        {
            get => new PointF(this.X, this.Y);
            set
            {
                this.Left = value.X;
                this.Top = value.Y;
            }
        }
        /// <summary>
        /// 获取或设置此 <see cref="Box"/> 矩形区域的大小
        /// </summary>
        [XmlConverter(typeof(XmlIgnoreAttribute))]
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
        /// 空矩形区域 <see cref="Box"/>
        /// </summary>
        public static Box Empty => new Box(0, 0, 0, 0);
        #endregion

        #region 方法
        /// <summary>
        /// 复制出一个新的实例
        /// </summary>
        /// <returns></returns>
        public Box Clone() => new Box(this.Left, this.Top, this.Width, this.Height);
        /// <summary>
        /// 确定此BOX是否与 <paramref name="box"/> 相交。
        /// </summary>
        /// <param name="box">矩形区域对象</param>
        /// <returns></returns>
        public bool IntersectsWith(Box box) => (box.X < X + this.Width) && (X < box.X + box.Width) && (box.Y < Y + this.Height) && (Y < box.Y + box.Height);
        /// <summary>
        /// 指定的坐标点是否包含在 <see cref="Box"/> 矩形中。
        /// </summary>
        /// <param name="x">横向坐标</param>
        /// <param name="y">纵向坐标</param>
        /// <returns></returns>
        public bool Contains(double x, double y) => this.X <= x && this.X + this.Width > x && this.Y >= y && this.Y + Height > y;
        /// <summary>
        /// 指定的坐标点是否包含在 <see cref="Box"/> 矩形中。
        /// </summary>
        /// <param name="p">坐标点</param>
        /// <returns></returns>
        public bool Contains(PointF p) => this.Contains(p.X, p.Y);
        /// <summary>
        /// 指定的矩形是否包含在 <see cref="Box"/> 矩形中。
        /// </summary>
        /// <param name="box">一个 <see cref="Box"/> 矩形。</param>
        /// <returns></returns>
        public bool Contains(Box box) => this.X <= box.X && box.X + box.Width <= this.X + this.Width && this.Y <= box.Y && box.Y + box.Height <= this.Y + this.Height;
        /// <summary>
        /// 将此矩形的位置调整指定的量。
        /// </summary>
        /// <param name="x">水平偏移量。</param>
        /// <param name="y">垂直偏移量。</param>
        public void Offset(float x, float y)
        {
            this.Left += x;
            this.Top += y;
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
            return $"{Left} {Top} {Width} {Height}";
        }
        ///<inheritdoc/>
        public object Parse(string value)
        {
            return new Box(value);
        }
        ///<inheritdoc/>
        public bool TryParse(string value, out Box result)
        {
            result = null;
            if (value.IsNullOrEmpty() || value.IndexOf(" ") == -1 || value.IsNotMatch(@"^[0-9\s]+$")) return false;
            result = new Box(value);
            return true;
        }
        ///<inheritdoc/>
        public bool Equals(Box other)
        {
            return this == other;
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
        /// <summary>
        /// 强制转换为矩形区域 <see cref="Rectangle"/> 对象
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
        ///<inheritdoc/>
        public override bool Equals(object obj)
        {
            return obj is Box box && Equals(box);
        }
        /// <summary>
        /// 测试两个 <see cref="Box"/> 结构的位置和大小是否相同。
        /// </summary>
        /// <param name="left">相等运算符左侧的<see cref="Box"/> 结构。</param>
        /// <param name="right">相等运算符右侧的<see cref="Box"/> 结构。</param>
        /// <returns></returns>
        public static bool operator ==(Box left, Box right)
        {
            if (left == null && right == null) return true;
            if (left == null || right == null) return false;
            return left.X == right.X && left.Y == right.Y && left.Width == right.Width && left.Height == right.Height;
        }
        /// <summary>
        /// 测试两个 <see cref="Box"/> 结构的位置或大小是否不同。
        /// </summary>
        /// <param name="left">不等运算符左侧的<see cref="Box"/> 结构。</param>
        /// <param name="right">不等运算符右侧的<see cref="Box"/> 结构。</param>
        /// <returns></returns>
        public static bool operator !=(Box left, Box right) => !(left == right);
        /// <summary>
        /// 给当前 <see cref="Box"/> 矩形区域移动坐标位置
        /// </summary>
        /// <param name="left">当前矩形区域  <see cref="Box"/> 。</param>
        /// <param name="point">坐标点 <see cref="PointF"/> 。</param>
        /// <returns></returns>
        public static Box operator +(Box left, PointF point)
        {
            return new Box(left.X + point.X, left.Y + point.Y, left.Width, left.Height);
        }
        /// <summary>
        /// 给当前 <see cref="Box"/> 矩形区域移动坐标位置
        /// </summary>
        /// <param name="left">当前  <see cref="Box"/> 。</param>
        /// <param name="point">坐标点 <see cref="PointF"/> 。</param>
        /// <returns></returns>
        public static Box operator -(Box left, PointF point)
        {
            return new Box(left.X - point.X, left.Y - point.Y, left.Width, left.Height);
        }
        /// <summary>
        /// 给当前矩形区域 <see cref="Box"/> 扩大宽高。
        /// </summary>
        /// <param name="left">当前  <see cref="Box"/> 。</param>
        /// <param name="size">宽高 <see cref="SizeF"/> 。</param>
        /// <returns></returns>
        public static Box operator +(Box left, SizeF size)
        {
            return new Box(left.X, left.Y, left.Width + size.Width, left.Height + size.Height);
        }
        /// <summary>
        /// 给当前矩形区域 <see cref="Box"/> 缩小宽高。
        /// </summary>
        /// <param name="left">当前  <see cref="Box"/> 。</param>
        /// <param name="size">宽高 <see cref="SizeF"/> 。</param>
        /// <returns></returns>
        public static Box operator -(Box left, SizeF size)
        {
            return new Box(left.X, left.Y, left.Width - size.Width, left.Height - size.Height);
        }
        /// <summary>
        /// 与矩形区域对象 <paramref name="box"/> 之间的并集。
        /// </summary>
        /// <param name="box">一个 <see cref="Box"/> 矩形区域。</param>
        public void Union(Box box)
        {
            var result = Union(box, this);
            this.Left = result.X;
            this.Top = result.Y;
            this.Width = result.Width;
            this.Height = result.Height;
        }
        /// <summary>
        /// 与对象 <paramref name="box"/> 之前的交点。
        /// </summary>
        /// <param name="box">一个 <see cref="Box"/> 矩形区域。</param>
        public void Intersect(Box box)
        {
            var result = Intersect(box, this);
            this.Left = result.X;
            this.Top = result.Y;
            this.Width = result.Width;
            this.Height = result.Height;
        }
        /// <summary>
        /// 创建一个矩形，表示 <paramref name="a"/> 和 <paramref name="b"/> 之间有交点，如果没有交点，则返回空矩形
        /// </summary>
        /// <param name="a">一个 <see cref="Box"/> 矩形区域。</param>
        /// <param name="b">一个 <see cref="Box"/> 矩形区域。</param>
        /// <returns></returns>
        public static Box Intersect(Box a, Box b)
        {
            var x1 = Math.Max(a.X, b.X);
            var x2 = Math.Min(a.X + a.Width, b.X + b.Width);
            var y1 = Math.Max(a.Y, b.Y);
            var y2 = Math.Min(a.Y + a.Height, b.Y + b.Height);
            if (x2 >= x1 && y2 >= y1)
                return new Box(x1, y1, x2 - x1, y2 - y1);
            return Empty;
        }
        /// <summary>
        /// 创建一个矩形，表示 <paramref name="a"/> 和 <paramref name="b"/> 之间的并集。
        /// </summary>
        /// <param name="a">一个 <see cref="Box"/> 矩形区域。</param>
        /// <param name="b">一个 <see cref="Box"/> 矩形区域。</param>
        /// <returns></returns>
        public static Box Union(Box a, Box b)
        {
            var x1 = Math.Min(a.X, b.X);
            var x2 = Math.Max(a.X + a.Width, b.X + b.Width);
            var y1 = Math.Min(a.Y, b.Y);
            var y2 = Math.Max(a.Y + a.Height, b.Y + b.Height);
            return new Box(x1, y1, x2 - x1, y2 - y1);
        }
        #endregion
    }
}