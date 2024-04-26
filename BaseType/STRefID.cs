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
    /// ST_RefID类型
    /// </summary>
    public class STRefID:IValue<STRefID>,IEquatable<STRefID>
    {
        #region 构造器
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        public STRefID()
        {

        }
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="value">值</param>
        public STRefID(uint value)
        {
            Value = value;
        }
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="value">值</param>
        public STRefID(string value)
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
            return new STRefID(value);
        }
        ///<inheritdoc/>
        public bool TryParse(string value, out STRefID result)
        {
            result = null;
            if (value.StartsWith("-") || !value.IsNumberic()) return false;
            result = new STRefID(value);
            return true;
        }
        /// <summary>
        /// 显示转换
        /// </summary>
        /// <param name="v">值</param>
        public static explicit operator string(STRefID v)
        {
            return v.ToString();
        }
        /// <summary>
        /// 隐式转换
        /// </summary>
        /// <param name="v">值</param>
        public static implicit operator STRefID(string v)
        {
            return new STRefID(v);
        }
        /// <summary>
        /// 显示转换
        /// </summary>
        /// <param name="v">值</param>
        public static explicit operator uint(STRefID v)
        {
            return v.Value;
        }
        /// <summary>
        /// 隐式转换
        /// </summary>
        /// <param name="v">值</param>
        public static implicit operator STRefID(uint v)
        {
            return new STRefID(v);
        }
        /// <summary>
        /// 显示转换
        /// </summary>
        /// <param name="v">值</param>
        public static explicit operator int(STRefID v)
        {
            return (int)v.Value;
        }
        /// <summary>
        /// 隐式转换
        /// </summary>
        /// <param name="v">值</param>
        public static implicit operator STRefID(int v)
        {
            return new STRefID((uint)v);
        }
        /// <summary>
        /// 显示转换
        /// </summary>
        /// <param name="v">值</param>
        public static explicit operator STID(STRefID v)
        {
            return new STID(v.Value);
        }
        /// <summary>
        /// 隐式转换
        /// </summary>
        /// <param name="v">值</param>
        public static implicit operator STRefID(STID v)
        {
            return new STRefID(v.ToString().ToCast<uint>());
        }
        /// <summary>
        /// ID增加值
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="v">值</param>
        /// <returns></returns>
        public static STRefID operator +(STRefID id, uint v)
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
        public static STRefID operator -(STRefID id, uint v)
        {
            id.Value -= v;
            return id;
        }
        /// <summary>
        /// ID 自动加一
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public static STRefID operator ++(STRefID id)
        {
            id.Value++;
            return id;
        }
        /// <summary>
        /// ID 自动减一
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public static STRefID operator --(STRefID id)
        {
            id.Value--;
            return id;
        }
        ///<inheritdoc/>
        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }
        /// <summary>
        /// 两个对象是否相等
        /// </summary>
        /// <param name="other">另一个对象 <see cref="STRefID"/> 。</param>
        /// <returns></returns>
        public bool Equals(STRefID other)
        {
            return this == other;
        }
        /// <summary>
        /// 两个对象是否相等
        /// </summary>
        /// <param name="obj">另一个对象 <see cref="STRefID"/> 。</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is STRefID id && this == id;
        }
        /// <summary>
        /// 两个对象是否相等
        /// </summary>
        /// <param name="left">一个对象 <see cref="STRefID"/> 。</param>
        /// <param name="right">一个对象 <see cref="STRefID"/> 。</param>
        /// <returns></returns>
        public static bool operator ==(STRefID left, STRefID right)
        {
            if (left == null && right == null) return true;
            if (left == null || right == null) return false;
            return left.Value == right.Value;
        }
        /// <summary>
        /// 两个对象是否不相等
        /// </summary>
        /// <param name="left">一个对象 <see cref="STRefID"/> 。</param>
        /// <param name="right">一个对象 <see cref="STRefID"/> 。</param>
        /// <returns></returns>
        public static bool operator !=(STRefID left, STRefID right) => !(left == right);
        #endregion
    }
}