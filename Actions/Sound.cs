using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Attributes;
using XiaoFeng.Ofd.BaseType;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-27 14:39:36                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Actions
{
    /// <summary>
    /// 释放音频动作
    /// </summary>
    public class Sound
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Sound()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 引用资源文件中的音频资源标识
        /// </summary>
        [XmlAttribute]
        [Required]
        public STRefID ResourceID { get; set; }
        /// <summary>
        /// 播放的音量，聚会范围[0 100]
        /// </summary>
        [XmlAttribute]
        public int Volume { get; set; }
        /// <summary>
        /// 此音频是否需要循环播放，如果此属性为 <see langword="true"/> ，则 <see cref="Synchronous"/> 值无效，默认为 <see langword="false"/>
        /// </summary>
        [XmlAttribute]
        public bool Repeat { get; set; }
        /// <summary>
        /// 是否同步播放，<see langword="true"/> 表示后续动作应等待此音频播放结束后才能开始，<see langword="false"/> 表示立刻返回并开始下一个动作，默认值为 <see langword="false"/>
        /// </summary>
        [XmlAttribute]
        public bool Synchronous { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}