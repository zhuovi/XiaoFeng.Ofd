using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using XiaoFeng.Ofd.BasicStructure;

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
    public class OFDDocument
    {
        #region 构造器
        /// <summary>
        /// 创建 OFD 文件
        /// </summary>
        /// <param name="ofdPath">OFD 地址</param>
        public OFDDocument(string ofdPath)
        {
            this.OfdPath = ofdPath;
        }
        #endregion

        #region 属性
        /// <summary>
        /// OFD 地址
        /// </summary>
        public string OfdPath { get; set; }
        /// <summary>
        /// 文档结构
        /// </summary>
        public List<DocumentStructure> Documents { get; set; }
        #endregion

        #region 方法
        /// <summary>
        /// 初始化
        /// </summary>
        /// <returns></returns>
        async Task InitAsync()
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
    }
}