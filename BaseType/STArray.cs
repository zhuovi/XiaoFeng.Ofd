﻿using System;
using System.Collections.Generic;
using System.Text;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 20:49:41                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.BaseType
{
    /// <summary>
    /// ST_Array类型
    /// </summary>
    public class STArray : IValue<STArray>, IEquatable<STArray>
    {
        #region 构造器
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        public STArray()
        {

        }
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="args">参数值</param>
        public STArray(params object[] args)
        {
            if (args.Length == 0) return;
            Values.AddRange(args);
        }
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="value">值 用空格隔开</param>
        public STArray(string value)
        {
            if (value.IsNullOrEmpty()) return;
            var vals = value.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            vals.Each(a =>
            {
                //if (a.IsFloat()) Values.Add(a.ToCast<float>());
                Values.Add(a);
            });
        }
        #endregion

        #region 属性
        /// <summary>
        /// 值
        /// </summary>
        private List<object> Values { get; set; } = new List<object>();
        #endregion

        #region 方法
        /// <summary>
        /// 添加一个值
        /// </summary>
        /// <param name="value">值</param>
        public void Add(float value)
        {
            Values.Add(value);
        }
        /// <summary>
        /// 清空
        /// </summary>
        public void Clear() => Values.Clear();
        /// <summary>
        /// 显示转换
        /// </summary>
        /// <param name="v">值</param>
        public static explicit operator string(STArray v)
        {
            return v.ToString();
        }
        /// <summary>
        /// 隐式转换
        /// </summary>
        /// <param name="v">值</param>
        public static implicit operator STArray(string v)
        {
            return new STArray(v);
        }
        /// <summary>
        /// 显示转换
        /// </summary>
        /// <param name="v">值</param>
        public static explicit operator object[](STArray v)
        {
            return v.Values.ToArray();
        }
        /// <summary>
        /// 隐式转换
        /// </summary>
        /// <param name="v">值</param>
        public static implicit operator STArray(object[] v)
        {
            return new STArray(v);
        }
        ///<inheritdoc/>
        public override string ToString()
        {
            return Values.Join(" ");
        }
        ///<inheritdoc/>
        public object Parse(string value)
        {
            return new STArray(value);
        }
        ///<inheritdoc/>
        public bool TryParse(string value, out STArray result)
        {
            result = null;
            if (value.IsNullOrEmpty()) return false;
            result = new STArray(value);
            return true;
        }
        /// <summary>
        /// 是否相等
        /// </summary>
        /// <param name="other">其它数组</param>
        /// <returns></returns>
        public bool Equals(STArray other)
        {
            return this == other;
        }
        /// <summary>
        /// 是否相等
        /// </summary>
        /// <param name="obj">对象</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is STArray array && this == array;
        }
        ///<inheritdoc/>
        public override int GetHashCode()
        {
            return HashCode.Combine(this.Values.GetHashCode(), base.GetHashCode());
        }
        /// <summary>
        /// 两个对象是否相等
        /// </summary>
        /// <param name="left">左边对象 <see cref="STArray"/> </param>
        /// <param name="right">右边对象 <see cref="STArray"/> </param>
        /// <returns></returns>
        public static bool operator ==(STArray left, STArray right)
        {
            if (left == null && right == null) return true;
            if (left == null || right == null) return false;
            return left.ToString() == right.ToString();
        }
        /// <summary>
        /// 两个对象是否不相等
        /// </summary>
        /// <param name="left">左边对象 <see cref="STArray"/> </param>
        /// <param name="right">右边对象 <see cref="STArray"/> </param>
        /// <returns></returns>
        public static bool operator !=(STArray left, STArray right) => !(left == right);
        #endregion
    }
}