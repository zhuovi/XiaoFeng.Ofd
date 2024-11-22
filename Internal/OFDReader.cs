using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using XiaoFeng.Ofd.BaseType;
using XiaoFeng.Ofd.BasicStructure;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-29 14:23:03                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Internal
{
    /// <summary>
    /// OFD读取器
    /// </summary>
    public class OFDReader : BaseOFD
    {
        #region 构造器
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        public OFDReader(string filePath) : base(filePath)
        {
            Init();
        }
        #endregion

        #region 属性

        #endregion

        #region 方法

        #region 初始化
        /// <summary>
        /// 初始化
        /// </summary>
        void Init()
        {
            if (!this.ReadOFD()) return;
            this.ReadDocument();
        }
        #endregion

        #region 读取OFD文件
        /// <summary>
        /// 读取OFD文件
        /// </summary>
        /// <returns>是否读取成功</returns>
        bool ReadOFD()
        {
            string path = "OFD.xml";
            var file = this.FileZip.GetEntry(path);
            if (file == null)
            {
                return this.SetError("入口文件读取出错.");
            }
            var doc = file.Open();
            var bytes = new byte[doc.Length];
            doc.Read(bytes, 0, bytes.Length);
            doc.Close();
            var content = bytes.GetString();
            this.Ofd = content.XmlToEntity<OFD>();
            if (this.Ofd == null)
                return this.SetError("读取入口文件出错.");
            if (this.Ofd.DocBody == null || this.Ofd.DocBody.Count == 0)
                return this.SetError("读取文档配置节点出错.");
            return true;
        }
        /// <summary>
        /// 读取文档及资源文档
        /// </summary>
        /// <returns></returns>
        bool ReadDocument()
        {
            foreach (var body in this.Ofd.DocBody)
            {
                var structure = this.ReadDoc(body.DocRoot);
                if (structure == null) return false;

                this.Documents.Add(structure);
            }
            return true;
        }
        /// <summary>
        /// 读取文件流
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <returns></returns>
        byte[] ReadData(string path)
        {
            var file = this.FileZip.GetEntry(path);
            if (file == null)
                return Array.Empty<byte>();
            /*var bytes = new byte[file.Length];
            using(var stream = file.Open())
            {
                stream.Read(bytes, 0, bytes.Length);
            }
            return bytes;*/
            var ms = new MemoryStream();
            using (var stream = file.Open())
            {
                stream.CopyTo(ms);
            }
            return ms.ToArray();
        }
        /// <summary>
        /// 读取文档
        /// </summary>
        /// <param name="docPath">文档路径</param>
        /// <returns></returns>
        DocumentStructure ReadDoc(Location docPath)
        {
            //读取文档 Document.xml
            var fileDocument = this.FileZip.GetEntry(docPath.ToString());
            if (fileDocument == null)
            {
                this.SetError("文档文件读取出错.");
                return null;
            }
            var path = fileDocument.FullName.Substring(0, fileDocument.FullName.LastIndexOf("/") + 1);
            var Structure = new DocumentStructure();
            var docStream = fileDocument.Open();
            var bytes = new byte[docStream.Length];
            docStream.Read(bytes, 0, bytes.Length);
            docStream.Close();
            var content = bytes.GetString();
            var DocData = content.XmlToEntity<Document>();
            if (DocData == null)
            {
                this.SetError("读取文档文件出错.");
                return null;
            }
            Structure.Document = DocData;
            //读取文档资源
            var fileDocRes = this.FileZip.GetEntry(path + DocData.CommonData.FirstOrDefault().DocumentRes.ToString());
            if (fileDocRes == null)
            {
                this.SetError("文档资源文件读取出错.");
                return null;
            }
            var docResStream = fileDocRes.Open();
            bytes = new byte[docResStream.Length];
            docResStream.Read(bytes, 0, bytes.Length);
            docResStream.Close();
            content = bytes.GetString();
            var DocResData = content.XmlToEntity<DocumentRes>();
            if (DocResData == null)
            {
                this.SetError("读取文档资源文件出错.");
                return null;
            }
            Structure.DocumentRes = DocResData;
            //读取公共文档资源
            var filePubRes = this.FileZip.GetEntry(path + DocData.CommonData.FirstOrDefault().PublicRes.ToString());
            if (filePubRes == null)
            {
                this.SetError("文档公共资源文件读取出错.");
                return null;
            }
            var PubResStream = filePubRes.Open();
            bytes = new byte[PubResStream.Length];
            PubResStream.Read(bytes, 0, bytes.Length);
            PubResStream.Close();
            content = bytes.GetString();
            var PublicResData = content.XmlToEntity<PublicRes>();
            if (PublicResData == null)
            {
                this.SetError("读取公共文档资源文件出错.");
                return null;
            }
            Structure.PublicRes = PublicResData;

            //读取页面
            foreach (var p in DocData.Pages)
            {
                var page = this.FileZip.GetEntry(path + p.BaseLoc);
                if (page == null)
                {
                    this.SetError("读取页面文件出错.");
                    return null;
                }
                var pageStream = page.Open();
                bytes = new byte[pageStream.Length];
                pageStream.Read(bytes, 0, bytes.Length);
                pageStream.Close();
                content = bytes.GetString();
                var pageData = content.XmlToEntity<Page>();
                if (pageData == null)
                {
                    this.SetError("读取页面文件出错.");
                    return null;
                }
                Structure.Pages.Add(pageData);
            }
            return Structure;
        }

        #endregion

        #endregion
    }
}