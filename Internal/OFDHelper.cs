using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 12:05:11                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Internal
{
    /// <summary>
    /// 公用帮助类
    /// </summary>
    public static class OFDHelper
    {
        /// <summary>
        /// 文档命名空间
        /// </summary>
        public const string NAMESPACE_URI = "http://www.ofdspec.org/2016";
        /// <summary>
        /// 文档标识 
        /// </summary>
        public const string NAMESPACE_PREFIX = "ofd";
        /// <summary>
        /// 入口文件
        /// </summary>
        public const string MAIN_FILE = "OFD.xml";
        /// <summary>
        /// 文字宽度
        /// </summary>
        public const float CharWidth = 1.9f;

        /// <summary>
        /// 文档编码
        /// </summary>
        private static Encoding _OfdEncoding = Encoding.UTF8;
        /// <summary>
        /// 获取OFD的名称和命名空间
        /// </summary>
        /// <returns></returns>
        public static XmlSerializerNamespaces GetNamespaces()
        {
            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add(NAMESPACE_PREFIX, NAMESPACE_URI);
            return namespaces;
        }
        /// <summary>
        /// 获取或设置文档编码
        /// </summary>
        public static Encoding OFDEncoding
        {
            get
            {
                if (_OfdEncoding == null)
                    _OfdEncoding = Encoding.UTF8;
                return _OfdEncoding;
            }
            set => _OfdEncoding = value;
        }
    }
}