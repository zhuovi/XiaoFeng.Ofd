using System;
using System.Collections.Generic;
using System.Text;
using XiaoFeng.Ofd.Attributes;
using XiaoFeng.Ofd.BaseType;
using XiaoFeng.Ofd.Versions;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 15:03:07                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.BasicStructure
{
    /// <summary>
    /// 文件对象入口，可以存在多个，以便在一个文档中包含多个版式文档
    /// </summary>
    public class DocBody
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public DocBody()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 文档元数据信息描述
        /// </summary>
        [Required]
        public DocInfo DocInfo { get; set; }
        /// <summary>
        /// 指向文档根节点文档
        /// </summary>
        public Location DocRoot { get; set; }
        /// <summary>
        /// 包含多个版本描述节点，用于定义文件因注释和其它改动产生的版本信息
        /// </summary>
        public List<Version> Versions { get; set; }
        /// <summary>
        /// 指向该文档中签名和签章结构
        /// </summary>
        public Location Signatures { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}