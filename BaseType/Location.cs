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
*  Create Time : 2024-03-26 20:57:02                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.BaseType
{
    /// <summary>
    /// ST_Loc类型
    /// </summary>
    public class Location : IValue,IEquatable<Location>
    {
        #region 构造器
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        public Location()
        {

        }
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="value"></param>
        public Location(string value)
        {
            Value = value;
        }
        #endregion

        #region 属性
        /// <summary>
        /// 地址
        /// </summary>
        private string Value { get; set; }
        #endregion

        #region 方法
        ///<inheritdoc/>
        public override string ToString()
        {
            return Value;
        }
        ///<inheritdoc/>
        public object Parse(string value)
        {
            return new Location(value);
        }
        /// <summary>
        /// 是否相等
        /// </summary>
        /// <param name="other">另一个对象 <see cref="Location"/></param>
        /// <returns></returns>
        public bool Equals(Location other)
        {
            return this == other;
        }
        /// <summary>
        /// 是否相等
        /// </summary>
        /// <param name="other">另一个对象 <see cref="Location"/></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Location loc && Equals(loc);
        }
        /// <summary>
        /// 两个对象是否相等
        /// </summary>
        /// <param name="left">一个对象 <see cref="Location"/></param>
        /// <param name="right">一个对象 <see cref="Location"/></param>
        /// <returns></returns>
        public static bool operator ==(Location left,Location right)
        {
            if (left == null && right == null) return true;
            if (left == null || right == null) return false;
            return left.Value == right.Value;
        }
        /// <summary>
        /// 两个对象是否不相等
        /// </summary>
        /// <param name="left">一个对象 <see cref="Location"/></param>
        /// <param name="right">一个对象 <see cref="Location"/></param>
        /// <returns></returns>
        public static bool operator !=(Location left, Location right) => !(left == right);
        /// <summary>
        /// 显示转换
        /// </summary>
        /// <param name="v">值</param>
        public static explicit operator string(Location v)
        {
            return v.ToString();
        }
        /// <summary>
        /// 隐式转换
        /// </summary>
        /// <param name="v">值</param>
        public static implicit operator Location(string v)
        {
            return new Location(v);
        }
        ///<inheritdoc/>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }
}