using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Attributes;
using XiaoFeng.Ofd.BaseType;
using XiaoFeng.Ofd.Enum;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-27 14:39:47                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Actions
{
    /// <summary>
    /// 播放视频动作
    /// </summary>
    public class Movie
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Movie()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 引用资源文件中定义的视频资源标识
        /// </summary>
        [XmlAttribute]
        [Required]
        public STRefID ResourceID { get; set; }
        /// <summary>
        /// 放映参数，默认值为 <see cref="OperatorType.Play"/>
        /// </summary>
        [XmlAttribute]
        public OperatorType Operator { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}