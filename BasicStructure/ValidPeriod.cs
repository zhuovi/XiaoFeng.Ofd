using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 19:10:09                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.BasicStructure
{
    /// <summary>
    /// 有效期
    /// </summary>
    public class ValidPeriod
    {
        #region 构造器
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        public ValidPeriod() { }
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="startDate">有效期的开始日期</param>
        /// <param name="endDate">有效期的结束日期</param>
        public ValidPeriod(DateTime? startDate, DateTime? endDate)
        {
            if (startDate.HasValue && endDate.HasValue && endDate < startDate) return;
            if (startDate.HasValue)
                StartDate = startDate.Value;
            if (endDate.HasValue)
                EndDate = endDate.Value;
        }
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="startDate">有效期的开始日期</param>
        public ValidPeriod(DateTime startDate)
        {
            StartDate = startDate;
        }
        #endregion

        #region 属性
        /// <summary>
        /// 有效期的开始日期
        /// </summary>
        [XmlAttribute]
        public DateTime StartDate { get; set; }
        /// <summary>
        /// 有效期的结束日期
        /// </summary>
        [XmlAttribute]
        public DateTime EndDate { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}