using System;
using System.Collections.Generic;
using System.Text;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 21:00:04                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.BaseType
{
    /// <summary>
    /// ST_ID类型
    /// </summary>
    public class STID : IValue<STID>,IEquatable<STID>
    {
        #region 构造器
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        public STID()
        {

        }
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="value">值</param>
        public STID(uint value)
        {
            Value = value;
        }
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="value">值</param>
        public STID(string value)
        {
            Value = value.ToCast<uint>();
        }
        #endregion

        #region 属性
        /// <summary>
        /// 值
        /// </summary>
        private uint Value { get; set; }
        #endregion

        #region 方法
        ///<inheritdoc/>
        public override string ToString()
        {
            return Value.ToString();
        }
        ///<inheritdoc/>
        public object Parse(string value)
        {
            return new STID(value);
        }
        ///<inheritdoc/>
        public bool TryParse(string value, out STID result)
        {
            result = null;
            if (value.StartsWith("-") || !value.IsNumberic()) return false;
            result = new STID(value);
            return true;
        }
        ///<inheritdoc/>
        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }
        /// <summary>
        /// 两个对象是否相等
        /// </summary>
        /// <param name="other">另一个对象 <see cref="STID"/> 。</param>
        /// <returns></returns>
        public bool Equals(STID other)
        {
            return this == other;
        }
        /// <summary>
        /// 两个对象是否相等
        /// </summary>
        /// <param name="obj">另一个对象 <see cref="STID"/> 。</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is STID id && this == id;
        }
        /// <summary>
        /// 两个对象是否相等
        /// </summary>
        /// <param name="left">一个对象 <see cref="STID"/> 。</param>
        /// <param name="right">一个对象 <see cref="STID"/> 。</param>
        /// <returns></returns>
        public static bool operator ==(STID left,STID right)
        {
            if (left == null && right == null) return true;
            if (left == null || right == null) return false;
            return left.Value == right.Value;
        }
        /// <summary>
        /// 两个对象是否不相等
        /// </summary>
        /// <param name="left">一个对象 <see cref="STID"/> 。</param>
        /// <param name="right">一个对象 <see cref="STID"/> 。</param>
        /// <returns></returns>
        public static bool operator !=(STID left, STID right) => !(left == right);
        /// <summary>
        /// 显示转换
        /// </summary>
        /// <param name="v">值</param>
        public static explicit operator string(STID v)
        {
            return v.ToString();
        }
        /// <summary>
        /// 隐式转换
        /// </summary>
        /// <param name="v">值</param>
        public static implicit operator STID(string v)
        {
            return new STID(v);
        }
        /// <summary>
        /// 显示转换
        /// </summary>
        /// <param name="v">值</param>
        public static explicit operator uint(STID v)
        {
            return v.Value;
        }
        /// <summary>
        /// 隐式转换
        /// </summary>
        /// <param name="v">值</param>
        public static implicit operator STID(uint v)
        {
            return new STID(v);
        }
        /// <summary>
        /// 显示转换
        /// </summary>
        /// <param name="v">值</param>
        public static explicit operator int(STID v)
        {
            return (int)v.Value;
        }
        /// <summary>
        /// 隐式转换
        /// </summary>
        /// <param name="v">值</param>
        public static implicit operator STID(int v)
        {
            return new STID((uint)v);
        }
        /// <summary>
        /// ID增加值
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="v">值</param>
        /// <returns></returns>
        public static STID operator +(STID id, uint v)
        {
            id.Value += v;
            return id;
        }
        /// <summary>
        /// ID减少值
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="v">值</param>
        /// <returns></returns>
        public static STID operator -(STID id,uint v)
        {
            id.Value -= v;
            return id;
        }
        /// <summary>
        /// ID 自动加一
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public static STID operator ++(STID id)
        {
            id.Value++;
            return id;
        }
        /// <summary>
        /// ID 自动减一
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public static STID operator --(STID id)
        {
            id.Value--;
            return id;
        }
        /// <summary>
        /// 显示转换
        /// </summary>
        /// <param name="v">值</param>
        public static explicit operator STRefID(STID v)
        {
            return new STRefID(v.Value);
        }
        /// <summary>
        /// 隐式转换
        /// </summary>
        /// <param name="v">值</param>
        public static implicit operator STID(STRefID v)
        {
            return new STID(v.ToString().ToCast<uint>());
        }
        #endregion
    }
}