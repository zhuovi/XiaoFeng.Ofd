using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-04-23 11:19:45                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Internal
{
    /// <summary>
    /// 大小
    /// </summary>
    public class SizeF : IEquatable<SizeF>
    {
        #region 构造器
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        public SizeF() { }
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="width">宽</param>
        /// <param name="height">高</param>
        public SizeF(float width, float height)
        {
            this.Width = width;
            this.Height = height;
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
        /// 是否为空对象
        /// </summary>
        public bool IsEmpty => this.Width == 0 && this.Height == 0;

        #endregion

        #region 方法
        ///<inheritdoc/>
        public bool Equals(SizeF other)
        {
            return this == other;
        }
        ///<inheritdoc/>
        public override bool Equals(object obj)
        {
            return obj is SizeF d && this == d;
        }
        /// <summary>
        /// 两个 <see cref="SizeF"/> 宽高是否相同。
        /// </summary>
        /// <param name="sz1">相等运算符第一个 <see cref="RectaSizeSizeDDngle"/> 结构。</param>
        /// <param name="sz2">相等运算符第二个 <see cref="SizeF"/> 结构。</param>
        /// <returns></returns>
        public static bool operator ==(SizeF sz1, SizeF sz2) => sz1.Width == sz2.Width && sz1.Height == sz2.Height;
        /// <summary>
        /// 两个 <see cref="SizeF"/> 宽高是否不相同。
        /// </summary>
        /// <param name="sz1">不等运算符第一个 <see cref="SizeF"/> 结构。</param>
        /// <param name="sz2">不等运算符第二个 <see cref="SizeF"/> 结构。</param>
        /// <returns></returns>
        public static bool operator !=(SizeF sz1, SizeF sz2) => !(sz1 == sz2);
        ///<inheritdoc/>
        public override string ToString()
        {
            return $"{{Width={this.Width},Height={this.Height}}}";
        }
        ///<inheritdoc/>
        public override int GetHashCode()
        {
            return HashCode.Combine(Width, Height);
        }
        /// <summary>
        /// 一个大小 <see cref="SizeF"/> 减去另一个大小 <see cref="SizeF"/>
        /// </summary>
        /// <param name="sz1">减数 <see cref="SizeF"/> </param>
        /// <param name="sz2">被减数 <see cref="SizeF"/> </param>
        /// <returns></returns>
        public static SizeF Substract(SizeF sz1, SizeF sz2) => new SizeF(sz1.Width - sz2.Width, sz1.Height - sz2.Height);
        /// <summary>
        /// 两个 <see cref="SizeF"/> 相加
        /// </summary>
        /// <param name="sz1">一个 <see cref="SizeF"/></param>
        /// <param name="sz2">另一个 <see cref="SizeF"/></param>
        /// <returns></returns>
        public static SizeF Add(SizeF sz1, SizeF sz2) => new SizeF(sz1.Width + sz2.Width, sz1.Height + sz2.Height);
        /// <summary>
        /// 两个 <see cref="SizeF"/> 对象相加。
        /// </summary>
        /// <param name="sz1">一个 <see cref="SizeF"/> 对象。</param>
        /// <param name="sz2">一个 <see cref="SizeF"/> 对象。</param>
        /// <returns></returns>
        public static SizeF operator +(SizeF sz1, SizeF sz2) => Add(sz1, sz2);
        /// <summary>
        /// 两个 <see cref="SizeF"/> 对象相减。
        /// </summary>
        /// <param name="sz1">一个 <see cref="SizeF"/> 对象。</param>
        /// <param name="sz2">一个 <see cref="SizeF"/> 对象。</param>
        /// <returns></returns>
        public static SizeF operator -(SizeF sz1, SizeF sz2) => Substract(sz1, sz2);
        /// <summary>
        /// 给现在 <see cref="SizeF"/> 对象添加一个数
        /// </summary>
        /// <param name="left">一个 <see cref="SizeF"/> 对象。</param>
        /// <param name="right">数值</param>
        /// <returns></returns>
        public static SizeF operator +(SizeF left, float right) => new SizeF(left.Width + right, left.Height + right);
        /// <summary>
        /// 给现在 <see cref="SizeF"/> 对象减去一个数
        /// </summary>
        /// <param name="left">一个 <see cref="SizeF"/> 对象。</param>
        /// <param name="right">数值</param>
        /// <returns></returns>
        public static SizeF operator -(SizeF left, float right) => new SizeF(left.Width - right, left.Height - right);
        /// <summary>
        /// 给现在 <see cref="SizeF"/> 对象乘一个数
        /// </summary>
        /// <param name="left">一个 <see cref="SizeF"/> 对象。</param>
        /// <param name="right">数值</param>
        /// <returns></returns>
        public static SizeF operator *(SizeF left, float right) => new SizeF(left.Width * right, left.Height * right);
        /// <summary>
        /// 给现在 <see cref="SizeF"/> 对象除一个数
        /// </summary>
        /// <param name="left">一个 <see cref="SizeF"/> 对象。</param>
        /// <param name="right">数值</param>
        /// <returns></returns>
        public static SizeF operator /(SizeF left, float right) => new SizeF(left.Width / right, left.Height / right);
        #endregion
    }
}