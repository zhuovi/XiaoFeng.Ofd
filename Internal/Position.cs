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
namespace XiaoFeng.Ofd.Internal
{
    /// <summary>
    /// ST_Pos类型
    /// </summary>
    public class Position : IEquatable<Position>
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
        #endregion

        #region 方法
        ///<inheritdoc/>
        public override string ToString()
        {
            return $"{X} {Y}";
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
        #endregion
    }
}