using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Attributes;
using XiaoFeng.Ofd.Enum;
using XiaoFeng.Ofd.Internal;
using XiaoFeng.Xml;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 15:12:12                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.BasicStructure
{
    /// <summary>
    /// <para>入口文件模型 OFD.xml</para>
    /// <para>详情说明 见图 <see langword="3"/> ，见表 <see langword="3"/> </para>
    /// </summary>
    [XmlPath("OFD.xml")]
    public class OFD : XmlEntity<OFD>
    {
        #region 构造器
        /// <summary>
        /// 初始化一个新的实例
        /// </summary>
        public OFD() { this.DocBody = new List<DocBody>(); }
        /// <summary>
        /// 初始化一个新的实例
        /// </summary>
        /// <param name="version">文件格式的版本号</param>
        /// <param name="docType">文件格式子集类型</param>
        /// <param name="bodys">文件对象入口</param>
        public OFD(string version, DocumentType docType, List<DocBody> bodys = null)
        {
            if (version.IsNullOrEmpty()) version = "1.0";
            this.Version = version;
            this.DocType = docType;
            if (bodys != null)
                this.DocBody = bodys;
            else
                this.DocBody = new List<DocBody>();
        }
        #endregion

        #region 属性
        /// <summary>
        /// 文件格式的版本号,取值为"1.0"
        /// </summary>
        [XmlAttribute]
        [Required]
        public string Version { get; set; } = "1.0";
        /// <summary>
        /// 文件格式子集类型
        /// </summary>
        [XmlAttribute]
        [Required]
        [XmlConverter(typeof(StringEnumConverter))]
        public DocumentType DocType { get; set; } = DocumentType.OFD;
        /// <summary>
        /// 文件对象入口，可以存在多个，以便在一个文档中包含多个版式文档
        /// </summary>
        [Required]
        [XmlArrayItem("DocBody")]
        public List<DocBody> DocBody { get; set; }
        #endregion

        #region 方法
        /// <summary>
        /// 添加版式文档
        /// </summary>
        /// <param name="body">版式文档</param>
        public void AddDocBody(DocBody body)
        {
            if (body == null) return;
            if (this.DocBody == null) this.DocBody = new List<DocBody>();
            this.DocBody.Add(body);
        }
        /// <summary>
        /// 移除版式文档
        /// </summary>
        /// <param name="index">索引</param>
        public void RemoveDocBody(int index)
        {
            if (this.DocBody == null || this.DocBody.Count == 0 || this.DocBody.Count <= index) return;
            this.DocBody.RemoveAt(index);
        }
        /// <summary>
        /// 移除版式文档
        /// </summary>
        /// <param name="DocId">文档Id</param>
        public void RemoveDocBody(string DocId)
        {
            if (this.DocBody == null || this.DocBody.Count == 0) return;
            var index = this.DocBody.FindIndex(a => a.DocInfo.DocID == DocId);
            if (index < 0) return;
            this.DocBody.RemoveAt(index);
        }
        /// <summary>
        /// 清空版式文档
        /// </summary>
        public void ClearDocBody()
        {
            if (this.DocBody == null)
            {
                this.DocBody = new List<DocBody>();
                return;
            }
            if (this.DocBody.Count == 0) return;
            this.DocBody.Clear();
        }
        #endregion

        #region 释放
        ///<inheritdoc/>
        public override void Dispose()
        {
            base.Dispose(true);
        }
        ///<inheritdoc/>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing, () =>
            {
                if (this.DocBody != null)
                {
                    this.DocBody.Clear();
                    this.DocBody = null;
                }
            });
        }
        /// <summary>
        /// 析构器
        /// </summary>
        ~OFD() => this.Dispose(false);
        #endregion
    }
}