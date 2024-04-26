using System;
using System.Collections.Generic;
using System.Text;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 17:20:31                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.BaseType
{
    /// <summary>
    /// ST_Pos类型
    /// </summary>
    public class Position : IEquatable<Position>,IValue
    {
        #region 构造器
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        public Position()
        {

        }
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="x">X坐标</param>
        /// <param name="y">Y坐标</param>
        public Position(float x, float y)
        {
            X = x;
            Y = y;
        }
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="val">X Y 坐标字符串 如 "0 0"两个数值中间用空格隔开</param>
        public Position(string val)
        {
            if (val.IsNullOrEmpty()) return;
            var vals = val.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (vals.Length != 2) return;
            X = vals[0].ToCast<float>();
            Y = vals[1].ToCast<float>();
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
        public static Position Empty => new Position(0, 0);
        /// <summary>
        /// 当前对象是否为空
        /// </summary>
        public bool IsEmpty => this.X == 0 && this.Y == 0;
        #endregion

        #region 方法
        /// <summary>
        /// 两个 <see cref="Position"/> 位置是否相同。
        /// </summary>
        /// <param name="left">第一个 <see cref="Position"/> 对象。</param>
        /// <param name="right">第二个 <see cref="Position"/> 对象。</param>
        /// <returns></returns>
        public static bool operator ==(Position left, Position right)
        {
            if (left == null && right == null) return true;
            if (left == null || right == null) return false;
            return left.X == right.X && left.Y == right.Y;
        }
        /// <summary>
        /// 两个 <see cref="Position"/> 位置是否不相同。
        /// </summary>
        /// <param name="left">第一个 <see cref="Position"/> 对象。</param>
        /// <param name="right">第二个 <see cref="Position"/> 对象。</param>
        /// <returns></returns>
        public static bool operator !=(Position left, Position right) => !(left == right);
        ///<inheritdoc/>
        public override string ToString()
        {
            return $"{X} {Y}";
        }
        ///<inheritdoc/>
        public object Parse(string value)
        {
            return new Position(value);
        }
        ///<inheritdoc/>
        public bool TryParse(string value, out Position result)
        {
            result = null;
            if (value.IsNullOrEmpty() || value.IndexOf(" ") == -1 || value.IsNotMatch(@"^[0-9\s]+$")) return false;
            result = new Position(value);
            return true;
        }
        ///<inheritdoc/>
        public bool Equals(Position other)
        {
            return X == other.X && Y == other.Y;
        }
        /// <summary>
        /// 显示转换
        /// </summary>
        /// <param name="v">值</param>
        public static explicit operator string(Position v)
        {
            return v.ToString();
        }
        /// <summary>
        /// 隐式转换
        /// </summary>
        /// <param name="v">值</param>
        public static implicit operator Position(string v)
        {
            return new Position(v);
        }
        ///<inheritdoc/>
        public override int GetHashCode()
        {
            return HashCode.Combine(this.X, this.Y);
        }
        ///<inheritdoc/>
        public override bool Equals(object obj)
        {
            return obj is Position p && this == p;
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
        public void Offset(Position p) => this.Offset(p.X, p.Y);
        #endregion
    }
}