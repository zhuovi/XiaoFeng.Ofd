using System;
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
namespace XiaoFeng.Ofd.Internal
{
    /// <summary>
    /// ST_Array类型
    /// </summary>
    public class STArray
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
            this.Values.AddRange(args);
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
                if (a.IsFloat()) this.Values.Add(a.ToCast<float>());
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
            this.Values.Add(value);
        }
        /// <summary>
        /// 清空
        /// </summary>
        public void Clear() => this.Values.Clear();
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
        ///<inheritdoc/>
        public override string ToString()
        {
            return this.Values.Join(" ");
        }
        #endregion
    }
}