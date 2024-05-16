using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using XiaoFeng.Ofd.BaseType;
using XiaoFeng.Ofd.BasicStructure;
using XiaoFeng.Ofd.Enum;
using System.Linq;
using System.IO;
using XiaoFeng.Ofd.CustomTags;
using XiaoFeng.Xml;
using System.IO.Compression;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-29 12:01:17                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Internal
{
    /// <summary>
    /// Ofd文档
    /// </summary>
    public class OFDDocument:BaseOFD
    {
        #region 构造器
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        public OFDDocument() {
            this.OperatorStatus = OperatorStatus.CREATE;
            this.CreateOfdAsync().ConfigureAwait(false);
        }
        /// <summary>
        /// 打开 OFD 文件
        /// </summary>
        /// <param name="ofdPath">OFD 地址</param>
        public OFDDocument(string ofdPath) : base(ofdPath)
        {
            this.FilePath = ofdPath;
            this.OperatorStatus = OperatorStatus.READ;
            this.OpenOfdAsync().ConfigureAwait(false);
        }
        #endregion

        #region 属性
        /// <summary>
        /// 操作状态
        /// </summary>
        private OperatorStatus OperatorStatus { get; set; }
        #endregion

        #region 方法

        #region 创建OFD文件
        /// <summary>
        /// 创建OFD文件
        /// </summary>
        /// <returns></returns>
        async Task CreateOfdAsync()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;

            var docBody = new DocBody()
            {
                DocInfo = new DocInfo()
                {
                    DocID = Guid.NewGuid().ToString("N"),
                    Title = "未命名文档",
                    CreationDate = DateTime.Now,
                    CreatorVersion = version.ToString(),
                    Creator = "XiaoFeng.Ofd"
                },
                DocRoot = "Doc_0/Document.xml"
            };
            var ofd = new OFD()
            {
                DocBody = new List<DocBody> { docBody }
            };

            var commonData = new CommonData()
            {

            };
            var doc = new Document()
            {
                CommonData = new List<CommonData> { commonData }
            };
            await Task.CompletedTask;
        }
        #endregion

        #region 读取 OFD 文件
        /// <summary>
        /// 打开Ofd文件
        /// </summary>
        /// <returns></returns>
        async Task OpenOfdAsync()
        {
            if (!await this.ReadOfdAsync()) return;
            await this.ReadDocumentAsync();
        }
        /// <summary>
        /// 读取OFD文件
        /// </summary>
        /// <returns>是否读取成功</returns>
        async Task<bool> ReadOfdAsync()
        {
            string path = "OFD.xml";
            var file = this.FileZip.GetEntry(path);
            if (file == null)
            {
                return await this.SetErrorAsync("入口文件读取出错.");
            }
            var doc = file.Open();
            var bytes = new byte[doc.Length];
            await doc.ReadAsync(bytes, 0, bytes.Length).ConfigureAwait(false);
            doc.Close();
            var content = bytes.GetString();
            this.Ofd = content.XmlToEntity<OFD>();
            if (this.Ofd == null)
                return await this.SetErrorAsync("读取入口文件出错.");
            if (this.Ofd.DocBody == null || this.Ofd.DocBody.Count == 0)
                return await this.SetErrorAsync("读取文档配置节点出错.");
            return await Task.FromResult(true);
        }
        /// <summary>
        /// 读取文档及资源文档
        /// </summary>
        /// <returns></returns>
        async Task<bool> ReadDocumentAsync()
        {
            foreach (var body in this.Ofd.DocBody)
            {
                var structure = await this.ReadDocAsync(body.DocRoot);
                if (structure == null) return false;

                this.Documents.Add(structure);
            }
            return true;
        }
        /// <summary>
        /// 读取文档
        /// </summary>
        /// <param name="docPath">文档路径</param>
        /// <returns></returns>
        async Task<DocumentStructure> ReadDocAsync(Location docPath)
        {
            //读取文档 Document.xml
            var fileDocument = this.FileZip.GetEntry(docPath.ToString());
            if (fileDocument == null)
            {
                await this.SetErrorAsync("文档文件读取出错.");
                return null;
            }
            var path = fileDocument.FullName.Substring(0, fileDocument.FullName.LastIndexOf("/") + 1);
            var Structure = new DocumentStructure();
            var docStream = fileDocument.Open();
            var bytes = new byte[docStream.Length];
            await docStream.ReadAsync(bytes, 0, bytes.Length);
            docStream.Close();
            docStream.Dispose();
            var content = bytes.GetString();
            var DocData = content.XmlToEntity<Document>();
            if (DocData == null)
            {
                await this.SetErrorAsync("读取文档文件出错.");
                return Structure;
            }
            Structure.Document = DocData;

            //读取文档资源
            var fileDocRes = this.FileZip.GetEntry(path + DocData.CommonData.FirstOrDefault().DocumentRes.ToString());
            if (fileDocRes == null)
            {
                await this.SetErrorAsync("文档资源文件读取出错.");
                return Structure;
            }
            var docResStream = fileDocRes.Open();
            bytes = new byte[docResStream.Length];
            await docResStream.ReadAsync(bytes, 0, bytes.Length);
            docResStream.Close();
            docResStream.Dispose();
            content = bytes.GetString();
            var DocResData = content.XmlToEntity<DocumentRes>();
            if (DocResData == null)
            {
                await this.SetErrorAsync("读取文档资源文件出错.");
                return Structure;
            }
            Structure.DocumentRes = DocResData;
            DocResData.SetMultiMediaData(path, this.FileZip);

            //读取公共文档资源
            var filePubRes = this.FileZip.GetEntry(path + DocData.CommonData.FirstOrDefault().PublicRes.ToString());
            if (filePubRes == null)
            {
                await this.SetErrorAsync("文档公共资源文件读取出错.");
                return Structure;
            }
            var PubResStream = filePubRes.Open();
            bytes = new byte[PubResStream.Length];
            await PubResStream.ReadAsync(bytes, 0, bytes.Length);
            PubResStream.Close();
            PubResStream.Dispose();
            content = bytes.GetString();
            var PublicResData = content.XmlToEntity<PublicRes>();
            if (PublicResData == null)
            {
                await this.SetErrorAsync("读取公共文档资源文件出错.");
                return Structure;
            }
            Structure.PublicRes = PublicResData;

            //读取页面
            foreach (var p in DocData.Pages)
            {
                var page = this.FileZip.GetEntry(path + p.BaseLoc);
                if (page == null)
                {
                    await this.SetErrorAsync("读取页面文件出错.");
                    return Structure;
                }
                var pageStream = page.Open();
                bytes = new byte[pageStream.Length];
                await pageStream.ReadAsync(bytes, 0, bytes.Length);
                pageStream.Close();
                pageStream.Dispose();
                content = bytes.GetString();
                var pageData = content.XmlToEntity<Page>();
                if (pageData == null)
                {
                    await this.SetErrorAsync("读取页面文件出错.");
                    return Structure;
                }
                Structure.Pages.Add(pageData);
            }

            //读取模板
            if(DocData.CommonData!=null && DocData.CommonData.Count > 0)
            {
                var templatePages = DocData.CommonData.FirstOrDefault().TemplatePage;
                if(templatePages!=null && templatePages.Count > 0)
                {
                    foreach(var p in templatePages)
                    {
                        var page = this.FileZip.GetEntry(path + p.BaseLoc);
                        if (page == null)
                        {
                            await this.SetErrorAsync("读取模板页面文件出错.");
                            return Structure;
                        }
                        var pageStream = page.Open();
                        bytes = new byte[pageStream.Length];
                        await pageStream.ReadAsync(bytes, 0, bytes.Length);
                        pageStream.Close();
                        content = bytes.GetString();
                        var pageData = content.XmlToEntity<Page>();
                        if (pageData == null)
                        {
                            await this.SetErrorAsync("读取模板页面文件出错.");
                            return Structure;
                        }
                        Structure.TemplatePages.Add(pageData);
                    }
                }
            }
            //读取 tags
            var fileTags = this.FileZip.GetEntry(path + DocData.CustomTags);
            if (fileTags == null)
            {
                await this.SetErrorAsync("文档自定义标签文件读取出错.");
                return Structure;
            }
            var TagsStream = fileTags.Open();
            bytes = new byte[TagsStream.Length];
            await TagsStream.ReadAsync(bytes, 0, bytes.Length);
            TagsStream.Close();
            TagsStream.Dispose();

            content = bytes.GetString();
            var TagsData = content.XmlToEntity<CustomTags.CustomTags>();
            if (TagsData == null)
            {
                await this.SetErrorAsync("读取自定义标签文件出错.");
                return Structure;
            }
            Structure.CustomTags = TagsData;
            //读取自定义标引内容
            var subpath = fileTags.FullName.Substring(0, fileTags.FullName.LastIndexOf("/") + 1);
            foreach(var t in TagsData.Tags)
            {
                var fileTag = this.FileZip.GetEntry(subpath + t.FileLoc);
                if (fileTag == null)
                {
                    await this.SetErrorAsync("文档自定义标签文件读取出错.");
                    return null;
                }
                var TagStream = fileTag.Open();
                bytes = new byte[TagStream.Length];
                await TagStream.ReadAsync(bytes, 0, bytes.Length);
                TagStream.Close();
                TagStream.Dispose();

                content = bytes.GetString();
                var TagData = content.XmlToEntity();
                if (TagData == null)
                {
                    await this.SetErrorAsync("读取自定义标签文件出错.");
                    return null;
                }
                Structure.CustomTagList.Add((XmlValue)TagData);
            }

            //读取 Annots
            var fileAnnotations = this.FileZip.GetEntry(path + DocData.Annotations);
            if (fileAnnotations == null)
            {
                await this.SetErrorAsync("文档自定义标签文件读取出错.");
                return Structure;
            }
            var AnnotationsStream = fileAnnotations.Open();
            bytes = new byte[AnnotationsStream.Length];
            await AnnotationsStream.ReadAsync(bytes, 0, bytes.Length);
            AnnotationsStream.Close();
            AnnotationsStream.Dispose();

            content = bytes.GetString();
            var AnnotationsData = content.XmlToEntity<Annots.Annotations>();
            if (AnnotationsData == null)
            {
                await this.SetErrorAsync("读取自定义标签文件出错.");
                return Structure;
            }
            Structure.Annotations = AnnotationsData;
            //读取分布注释
            subpath = fileAnnotations.FullName.Substring(0, fileAnnotations.FullName.LastIndexOf("/") + 1);
            foreach(var a in AnnotationsData.Pages)
            {
                var fileAnnot = this.FileZip.GetEntry(subpath + a.FileLoc);
                if (fileAnnot == null)
                {
                    await this.SetErrorAsync("文档分页注释文件读取出错.");
                    return Structure;
                }
                var AnnotStream = fileAnnot.Open();
                bytes = new byte[AnnotStream.Length];
                await AnnotStream.ReadAsync(bytes, 0, bytes.Length);
                AnnotStream.Close();
                AnnotStream.Dispose();

                content = bytes.GetString();
                var AnnotData = content.XmlToEntity<Annots.PageAnnot>();
                if (AnnotData == null)
                {
                    await this.SetErrorAsync("读取分页注释文件出错.");
                    return Structure;
                }
                Structure.PageAnnots.Add(AnnotData);
            }
            return Structure;
        }
        #endregion

        #region 保存
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="path">保存地址</param>
        public bool Save(string path = "")
        {
            if (this.Ofd == null) return this.SetError("OFD入口文档写入出错.");
            this.FileZip = new System.IO.Compression.ZipArchive(System.IO.File.Open(path.Multivariate(this.FilePath), System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite, System.IO.FileShare.ReadWrite), System.IO.Compression.ZipArchiveMode.Update, false);

            //写入口文档 OFD.xml
            var ofdEntry = this.FileZip.CreateEntry("OFD.xml", System.IO.Compression.CompressionLevel.Fastest);
            var ofd = ofdEntry.Open();
            var ofdBytes = this.Ofd.GetBytes();
            ofd.Write(ofdBytes, 0, ofdBytes.Length);
            ofd.Close();
            ofd.Dispose();

            for (var i = 0; i < this.Ofd.DocBody.Count; i++)
            {
                var body = this.Ofd.DocBody[i];

                //写 Document.xml
                var docEntry = this.FileZip.CreateEntry(body.DocRoot.ToString());
                var doc = docEntry.Open();
                var Structure = this.Documents[i];
                var docBytes = Structure.Document.GetBytes();
                doc.Write(docBytes, 0, docBytes.Length);
                doc.Close();
                doc.Dispose();

                var rootPath = body.DocRoot.ToString().Substring(0, body.DocRoot.ToString().LastIndexOf("/") + 1);

                //写 DocumentRes.xml
                var docResEntry = this.FileZip.CreateEntry(rootPath + Structure.Document.CommonData.First().DocumentRes);
                var docResBytes = Structure.DocumentRes.GetBytes();
                var docRes = docResEntry.Open();
                docRes.Write(docResBytes, 0, docResBytes.Length);
                docRes.Close();
                docRes.Dispose();

                //写附件
                var medias = Structure.DocumentRes.MultiMedias;
                if (medias != null && medias.Count > 0)
                {
                    medias.Each(m =>
                    {
                        var _path = $"{rootPath + Structure.DocumentRes.BaseLoc}/{m.MediaFile}";
                        var entry = this.FileZip.CreateEntry(_path, CompressionLevel.Fastest);
                        var file = entry.Open();
                        file.Write(m.Bytes, 0, m.Bytes.Length);
                        file.Flush();
                        file.Close();
                        file.Dispose();
                       
                    });
                }

                //写 PublicRes.xml
                var pubResEntry = this.FileZip.CreateEntry(rootPath + Structure.Document.CommonData.First().PublicRes);
                var pubResBytes = Structure.PublicRes.GetBytes();
                var pubRes = pubResEntry.Open();
                pubRes.Write(pubResBytes, 0, pubResBytes.Length);
                pubRes.Close();
                pubRes.Dispose();

                //写 页面 Pages/Page_0/Content.xml
                for (var j = 0; j < Structure.Document.Pages.Count; j++)
                {
                    var p = Structure.Document.Pages[j];

                    var pageEntry = this.FileZip.CreateEntry(rootPath + p.BaseLoc);

                    var pageBytes = Structure.Pages[j].GetBytes();
                    var page = pageEntry.Open();
                    page.Write(pageBytes, 0, pageBytes.Length);
                    page.Close();
                }

                //写 模板页 Tpls/Tpl_0/Content.xml
                var templatePages = Structure.Document.CommonData.FirstOrDefault().TemplatePage;
                if (templatePages != null && templatePages.Count > 0)
                {
                    for (var j = 0; j < templatePages.Count; j++)
                    {
                        var t = templatePages[j];
                        var templateEntry = this.FileZip.CreateEntry(rootPath + t.BaseLoc);

                        var templateBytes = Structure.TemplatePages[j].GetBytes();
                        var template = templateEntry.Open();
                        template.Write(templateBytes, 0, templateBytes.Length);
                        template.Close();
                    }
                }

                //写注释  Annots
                if (Structure.Annotations != null)
                {
                    var annotsEntry = this.FileZip.CreateEntry(rootPath + Structure.Document.Annotations);
                    var annotsBytes = Structure.Annotations.GetBytes();
                    var annots = annotsEntry.Open();
                    annots.Write(annotsBytes, 0, annotsBytes.Length);
                    annots.Close();
                    annots.Dispose();

                    for (var j = 0; j < Structure.Annotations.Pages.Count; j++)
                    {
                        var page = Structure.Annotations.Pages[j];
                        var pageModel = Structure.PageAnnots[j];
                        var annotEntry = this.FileZip.CreateEntry($"{rootPath}{Structure.Document.Annotations.ToString().Substring(0, Structure.Document.Annotations.ToString().IndexOf("/") + 1)}{page.FileLoc}");
                        var annotBytes = pageModel.GetBytes();
                        var annot = annotEntry.Open();
                        annot.Write(annotBytes, 0, annotBytes.Length);
                        annot.Close();
                        annot.Dispose();
                    }
                }

                //写自定义标引
                if (Structure.CustomTags != null)
                {
                    var customTagsEntry = this.FileZip.CreateEntry(rootPath + Structure.Document.CustomTags);
                    var customTagsBytes = Structure.CustomTags.GetBytes();
                    var customTags = customTagsEntry.Open();
                    customTags.Write(customTagsBytes, 0, customTagsBytes.Length);
                    customTags.Close();
                    customTags.Dispose();

                    for (var j = 0; j < Structure.CustomTags.Tags.Count; j++)
                    {
                        var CustomTags = Structure.CustomTags.Tags[j];
                        var CustomTag = Structure.CustomTagList[j];
                        var customEntry = this.FileZip.CreateEntry($"{rootPath}{Structure.Document.CustomTags.ToString().Substring(0, Structure.Document.CustomTags.ToString().IndexOf("/") + 1)}{CustomTags.FileLoc}");
                        var customBytes = CustomTag.ChildNodes.Last().EntityToXml(OFDHelper.OFDEncoding, false, true, true, true, false, OFDHelper.GetNamespaces()).GetBytes(OFDHelper.OFDEncoding);
                        var custom = customEntry.Open();
                        custom.Write(customBytes, 0, customBytes.Length);
                        custom.Close();
                        custom.Dispose();
                    }
                }
            }

            this.FileZip.Dispose();
            return true;
        }
        #endregion

        public List<Page> Pages
        {
            get { return this.Documents.First().Pages; }
        }
        #endregion
    }
}