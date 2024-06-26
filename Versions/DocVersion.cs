﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Attributes;
using XiaoFeng.Ofd.BaseType;
using XiaoFeng.Ofd.BasicStructure;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 15:32:36                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Versions
{
    /// <summary>
    /// <para>文档版本</para>
    /// <para>版本信息在独立的文件中描述，如图90所示，版本定义结构中列出了一个OFD文档版本中所需的所有文件</para>
    /// 详情说明 见图 <see langword="90"/> ，见表 <see langword="71"/> </para>
    /// </summary>
    public class DocVersion
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public DocVersion()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 版本标识
        /// </summary>
        [XmlAttribute]
        [Required]
        public string ID { get; set; }
        /// <summary>
        /// 文件适用的格式版本
        /// </summary>
        [XmlAttribute]
        public string Version { get; set; }
        /// <summary>
        /// 版本名称
        /// </summary>
        [XmlAttribute]
        public string Name { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlAttribute]
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// 版本包含的文件列表
        /// </summary>
        public List<File> FileList { get; set; }
        /// <summary>
        /// 该版本的入口文件
        /// </summary>
        public Location DocRoot { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}