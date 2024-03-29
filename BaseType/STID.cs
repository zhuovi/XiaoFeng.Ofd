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
    public class STID
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
        #endregion
    }
}