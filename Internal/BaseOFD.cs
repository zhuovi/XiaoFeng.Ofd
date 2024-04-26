using System;
using System.Collections.Generic;
using System.Text;
using XiaoFeng.Ofd.BasicStructure;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-04-24 16:54:47                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Internal
{
    /// <summary>
    /// OFD 基础类
    /// </summary>
    public class BaseOFD : Disposable
    {
        #region 构造器
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        public BaseOFD()
        {
            this.Documents = new List<DocumentStructure>();
            this.Ofd = new OFD();
        }
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="filePath">文件路径</param>
        public BaseOFD(string filePath) : this()
        {
            this.FilePath = filePath;
        }
        #endregion

        #region 属性
        /// <summary>
        /// 文件路径
        /// </summary>
        public string FilePath { get; set; }
        /// <summary>
        /// 文档结构
        /// </summary>
        public List<DocumentStructure> Documents { get; set; }
        /// <summary>
        /// OFD 文档
        /// </summary>
        public OFD Ofd { get; set; }
        #endregion

        #region 方法

        #endregion

        #region 释放
        ///<inheritdoc/>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing, () =>
            {

            });
        }
        ///<inheritdoc/>
        public override void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
        /// <summary>
        /// 析构器
        /// </summary>
        ~BaseOFD()
        {
            this.Dispose(false);
        }
        #endregion
    }
}