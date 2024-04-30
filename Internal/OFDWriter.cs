using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using XiaoFeng.Data.SQL;
using XiaoFeng.Ofd.BasicStructure;
using XiaoFeng.Ofd.Enum;
using XiaoFeng.Ofd.Fonts;
using XiaoFeng.Ofd.PageDescription;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-29 14:23:14                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Internal
{
    /// <summary>
    /// OFD写入器
    /// </summary>
    public class OFDWriter : BaseOFD
    {
        #region 构造器
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="filePath">文档路径</param>
        public OFDWriter(string filePath) : base(filePath)
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
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            var docBody = new DocBody()
            {
                DocInfo = new DocInfo()
                {
                    DocID = Guid.NewGuid().ToString("N"),
                    Title = "未命名文档",
                    CreationDate = DateTime.Now,
                    ModDate = DateTime.Now,
                    CreatorVersion = version.ToString(),
                    Creator = "XiaoFeng.Ofd",
                    Author = "EELF.CN"
                },
                DocRoot = "Doc_0/Document.xml"
            };
            this.Ofd.DocType = DocumentType.OFD;
            this.Ofd.AddDocBody(docBody);
            var docStruct = new DocumentStructure();
            var doc = new Document();
            var commonData = new CommonData
            {
                MaxUnitID = 0,
                PageArea = new PageArea
                {
                    PhysicalBox = new BaseType.Box("0 0 210 297")
                }
            };
            doc.AddCommonData(commonData);

            docStruct.Document = doc;

            var pubRes = new PublicRes();
            var simHei = Font.SimHei((uint)doc.GetMaxUnitIDAndAdd());
            pubRes.AddFont(simHei);
            docStruct.PublicRes = pubRes;

            var page = new Page();
            var layer = new Layer()
            {
                ID = doc.GetMaxUnitIDAndAdd(),
                Type = LayerType.Body
            };
            var txtObject = new TextObject
            {
                ID = doc.GetMaxUnitIDAndAdd(),
                FillColor = new PageDescription.Color("51 51 51"),
                FontID = simHei.ID,
                Size = 8.4667,
                Boundary = new BaseType.Box("73.8795 26.624 61.6524 8.4843"),
                Weight = 700
            };
            txtObject.AddText(new TextCode
            {
                Value = "Hello World!",
                X = 1.4314,
                Y = 7.2849,
                DeltaX = new BaseType.STArray("g 2 8.5088 8.4667 g 3 8.5088")
            });
            layer.AddPageBlock(txtObject);

            var txt2 = new TextObject
            {
                ID = doc.GetMaxUnitIDAndAdd(),
                FontID = simHei.ID,
                Size = 4.9565,
                Boundary = new BaseType.Box("30.9183 44.3475 42.3943 4.9565"),
                Weight = 300
            };
            txt2.AddText(new TextCode
            {
                Value = "尊敬的领导、老师：",
                X = 0.8317,
                Y = 4.251,
                DeltaX = new BaseType.STArray("4.9529 4.9105 g 2 4.9529 4.9105 g 2 4.9529 4.9105")
            });
            layer.AddPageBlock(txt2);
            page.AddLayer(layer);
            docStruct.AddPage(page);
            docStruct.AddPage(page); 
            docStruct.AddPage(page);

            var docRes = new DocumentRes();

            docStruct.DocumentRes = docRes;

            

            this.Documents.Add(docStruct);
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
            //写入口文档
            var ofdEntry = this.FileZip.CreateEntry("OFD.xml", System.IO.Compression.CompressionLevel.Fastest);
            var ofd = ofdEntry.Open();
            var ofdBytes = this.Ofd.GetBytes();
            ofd.Write(ofdBytes,0, ofdBytes.Length);
            ofd.Close();
            for (var i = 0; i < this.Ofd.DocBody.Count; i++)
            {
                var body = this.Ofd.DocBody[i];
                var docEntry = this.FileZip.CreateEntry(body.DocRoot.ToString());
                var doc = docEntry.Open();
                var Structure = this.Documents[i];
                var docBytes = Structure.Document.GetBytes();
                doc.Write(docBytes, 0, docBytes.Length);
                doc.Close();

                var rootPath = body.DocRoot.ToString().Substring(0, body.DocRoot.ToString().LastIndexOf("/") + 1);

                var docResEntry = this.FileZip.CreateEntry(rootPath + Structure.Document.CommonData.First().DocumentRes);
                var docResBytes = Structure.DocumentRes.GetBytes();
                var docRes = docResEntry.Open();
                docRes.Write(docResBytes,0, docResBytes.Length);
                docRes.Close();

                var pubResEntry = this.FileZip.CreateEntry(rootPath + Structure.Document.CommonData.First().PublicRes);
                var pubResBytes = Structure.PublicRes.GetBytes();
                var pubRes = pubResEntry.Open();
                pubRes.Write(pubResBytes,0, pubResBytes.Length);
                pubRes.Close();

                for(var j = 0; j < Structure.Document.Pages.Count; j++)
                {
                    var p = Structure.Document.Pages[j];

                    var pageEntry = this.FileZip.CreateEntry(rootPath + p.BaseLoc);

                    var pageBytes = Structure.Pages[j].GetBytes();
                    var page = pageEntry.Open();
                    page.Write(pageBytes, 0, pageBytes.Length);
                    page.Close();
                }
            }

            this.FileZip.Dispose();
            return true;
        }
        #endregion

        #region 添加文本
        /// <summary>
        /// 添加文本
        /// </summary>
        /// <param name="text">文本信息</param>
        public void WriteText(string text)
        {
            var txt = new TextObject();
            txt.AddText(text);
        }
        #endregion

        #endregion
    }
}