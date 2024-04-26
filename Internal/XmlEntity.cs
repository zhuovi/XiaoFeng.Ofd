using System;
using System.Collections.Generic;
using System.Text;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-04-23 17:24:12                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Internal
{
    /// <summary>
    /// Xml实体操作类
    /// </summary>
    public class XmlEntity<T>:Disposable
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public XmlEntity()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 文件路径
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// 实体数据
        /// </summary>
        //public T Entity { get; set; }
        #endregion

        #region 方法
        /// <summary>
        /// 保存
        /// </summary>
        public void Save()
        {
            var a = this.EntityToXml();

            var b = "";
        }
        /// <summary>
        /// 读取
        /// </summary>
        public void Reader()
        {

        }

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
            this.Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        /// <summary>
        /// 析构器
        /// </summary>
        ~XmlEntity()
        {
            this.Dispose(false);
        }
        #endregion

        #endregion
    }
}