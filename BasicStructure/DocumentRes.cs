using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Attributes;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-04-24 18:12:05                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.BasicStructure
{
    /// <summary>
    /// 文档资源
    /// </summary>
    [XmlPath("Doc_{0}/DocumentRes.xml")]
    [XmlRoot("Res")]
    public class DocumentRes : Res
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public DocumentRes()
        {

        }
        #endregion

        #region 属性

        #endregion

        #region 方法
        /// <summary>
        /// 设置媒体数据
        /// </summary>
        /// <param name="prefix">路径前缀</param>
        /// <param name="zip">文档流</param>
        public void SetMultiMediaData(string prefix, ZipArchive zip)
        {
            if (this.MultiMedias == null || this.MultiMedias.Count == 0) return;
            this.MultiMedias.Each(m =>
            {
                var entry = zip.GetEntry($"{prefix}{this.BaseLoc}/{m.MediaFile}");
                if (entry != null)
                {
                    var file = entry.Open();
                    var bytes = new byte[file.Length];
                    file.Read(bytes, 0, bytes.Length);
                    file.Close();
                    file.Dispose();
                    m.Bytes = bytes;
                }
            });
        }
        #endregion
    }
}