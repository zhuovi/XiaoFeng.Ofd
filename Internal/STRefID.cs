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
namespace XiaoFeng.Ofd.Internal
{
    /// <summary>
    /// ST_RefID类型
    /// </summary>
    public class STRefID
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
            this.Value = value.ToCast<uint>();
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
            return this.Value.ToString();
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
        #endregion
    }
}