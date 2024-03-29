using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.BaseType;
using XiaoFeng.Ofd.Enum;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 14:44:07                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.BasicStructure
{
    /// <summary>
    /// 文件元数据属性模型
    /// </summary>
    public class DocInfo
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public DocInfo()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 采用UUID算法生成的由32个字符组成的文件标识。每个DocID在文档创建或生成的时候进行分配
        /// </summary>
        public string DocID { get; set; } = Guid.NewGuid().ToString("N");
        /// <summary>
        /// 文档标题。标题可以与文件名不同
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 文档作者
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// 文档主题
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// 文档摘要与注释
        /// </summary>
        public string Abstract { get; set; }
        /// <summary>
        /// 文档创建日期
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 文档最近修改日期
        /// </summary>
        public DateTime ModDate { get; set; }
        /// <summary>
        /// 文档分类
        /// </summary>
        public DocumentUsage DocUsage { get; set; } = DocumentUsage.Normal;
        /// <summary>
        /// 文档封面，此路径指向一个图片文件
        /// </summary>
        public Location Cover { get; set; }
        /// <summary>
        /// 关键词集合,每一个关键词用一个"Keyword"子节点来表达
        /// </summary>
        [XmlArray("Keywrods")]
        [XmlArrayItem("Keyword")]
        public List<string> Keywords { get; set; }
        /// <summary>
        /// 创建文档的应用程序
        /// </summary>
        public string Creator { get; set; }
        /// <summary>
        /// 创建文档的应用程序的版本信息
        /// </summary>
        public string CreatorVersion { get; set; }
        /// <summary>
        /// 用户自定义元数据集合。
        /// </summary>
        public List<CustomData> CustomDatas { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}