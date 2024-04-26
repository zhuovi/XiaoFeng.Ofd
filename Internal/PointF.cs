using System;
using System.Collections.Generic;
using System.Text;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-04-23 11:50:56                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Internal
{
    /// <summary>
    /// 坐标点
    /// </summary>
    public class PointF : IEquatable<PointF>
    {
        #region 构造器
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        public PointF() { }
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="x">x坐标</param>
        /// <param name="y">y坐标</param>
        public PointF(float x, float y)
        {
            this.X = x;
            this.Y = y;
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
        /// 空对象
        /// </summary>
        public static PointF Empty => new PointF(0, 0);
        /// <summary>
        /// 当前对象是否为空
        /// </summary>
        public bool IsEmpty => this.X == 0 && this.Y == 0;
        #endregion

        #region 方法
        /// <summary>
        /// 两个 <see cref="PointF"/> 位置是否相同。
        /// </summary>
        /// <param name="p1">第一个 <see cref="PointF"/> 对象。</param>
        /// <param name="p2">第二个 <see cref="PointF"/> 对象。</param>
        /// <returns></returns>
        public static bool operator ==(PointF p1, PointF p2) => p1.X == p2.X && p1.Y == p2.Y;
        /// <summary>
        /// 两个 <see cref="PointF"/> 位置是否不相同。
        /// </summary>
        /// <param name="p1">第一个 <see cref="PointF"/> 对象。</param>
        /// <param name="p2">第二个 <see cref="PointF"/> 对象。</param>
        /// <returns></returns>
        public static bool operator !=(PointF p1, PointF p2) => !(p1 == p2);
        ///<inheritdoc/>
        public bool Equals(PointF other)
        {
            return this == other;
        }
        ///<inheritdoc/>
        public override bool Equals(object obj)
        {
            return obj is PointF p && this == p;
        }
        /// <summary>
        /// 将坐标点移动到增加量指定位置
        /// </summary>
        /// <param name="dx">横向增加量</param>
        /// <param name="dy">纵向增加量</param>
        public void Offset(float dx, float dy)
        {
            this.X += dx;
            this.Y += dy;
        }
        /// <summary>
        /// 将坐标点移动到增加后坐标点的指定位置
        /// </summary>
        /// <param name="p">坐标点</param>
        public void Offset(PointF p) => this.Offset(p.X, p.Y);
        ///<inheritdoc/>
        public override string ToString()
        {
            return $"{{X={this.X},Y={this.Y}}}";
        }
        ///<inheritdoc/>
        public override int GetHashCode()
        {
            return HashCode.Combine(this.X, this.Y);
        }
        #endregion
    }
}