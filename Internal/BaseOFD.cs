﻿using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Threading.Tasks;
using XiaoFeng.IO;
using XiaoFeng.Ofd.BasicStructure;
using XiaoFeng.Ofd.Enum;

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
            this.FileZip = new ZipArchive(System.IO.File.Open(filePath, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite, System.IO.FileShare.ReadWrite), ZipArchiveMode.Update, false, Encoding.UTF8);
        }
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="stream">文件流</param>
        public BaseOFD(Stream stream) : this()
        {
            this.FileZip = new ZipArchive(stream, ZipArchiveMode.Update, false, Encoding.UTF8);
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
        /// <summary>
        /// 文档流
        /// </summary>
        public ZipArchive FileZip { get; set; }
        /// <summary>
        /// 操作状态
        /// </summary>
        public OfdStatus Status { get; set; } = OfdStatus.SUCCESS;
        /// <summary>
        /// 错误信息
        /// </summary>
        public List<string> ErrorMessage { get; set; } = new List<string>();
        #endregion

        #region 方法
        /// <summary>
        /// 设置成功状态
        /// </summary>
        public void SetSuccess() => this.Status = OfdStatus.SUCCESS;
        /// <summary>
        /// 设置成功状态
        /// </summary>
        /// <returns></returns>
        public async Task SetSuccessAsync() => await Task.Run(() => this.SetSuccess());
        /// <summary>
        /// 设置错误信息
        /// </summary>
        /// <param name="message">错误信息</param>
        public bool SetError(string message)
        {
            this.Status = OfdStatus.ERROR;
            if (message.IsNullOrEmpty()) return false;
            if (this.ErrorMessage == null) this.ErrorMessage = new List<string>();
            this.ErrorMessage.Add(message);
            return false;
        }
        /// <summary>
        /// 设置错误信息
        /// </summary>
        /// <param name="message">错误信息</param>
        /// <returns></returns>
        public async Task<bool> SetErrorAsync(string message)
        {
            return await Task.FromResult(this.SetError(message)).ConfigureAwait(false);
        }
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