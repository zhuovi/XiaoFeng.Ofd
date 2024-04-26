using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using XiaoFeng.Ofd.BasicStructure;
using XiaoFeng.Ofd.Enum;
using XiaoFeng.Ofd.Fonts;

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
                    CreateDate = DateTime.Now,
                    CreatorVersion = version.ToString(),
                    Creator = "XiaoFeng.Ofd"
                },
                DocRoot = "Doc_0/Document.xml"
            };
            this.Ofd.AddDocBody(docBody);
            var docStruct = new DocumentStructure();
            var doc = new Document();
            var commonData = new CommonData();

            doc.AddCommonData(commonData);

            docStruct.Document = doc;
            var page = new Page();
            var layer = new Layer();
            var txtObject = new TextObject();
            txtObject.AddText(new TextCode
            {
                 Value="Hello World!"
            });
            layer.AddPageBlock(txtObject);
            page.AddLayer(layer);
            docStruct.AddPage(page);

            var docRes = new DocumentRes();

            docRes.AddMultiMedia(new MultiMedia
            {
                ID = doc.GetMaxUnitIDAndAdd(),
                Type = MultiMediaType.IMAGE,
                MediaFile = $"image_{doc.GetMaxUnitIDAndAdd()}.png"
            });
            docStruct.DocumentRes = docRes;

            var pubRes = new PublicRes();
            var simHei = Font.SimHei(1);
            simHei.ID = doc.GetMaxUnitIDAndAdd();
            pubRes.AddFont(simHei);
            docStruct.PublicRes = pubRes;

            this.Documents.Add(docStruct);
        }
        #endregion

        public void WriteText(string text)
        {
            var txt = new TextObject();
            
        }
        

        #endregion
    }
}