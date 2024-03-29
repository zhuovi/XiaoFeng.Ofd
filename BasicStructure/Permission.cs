using System;
using System.Collections.Generic;
using System.Text;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 19:00:17                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.BasicStructure
{
    /// <summary>
    /// 文档权限声明
    /// </summary>
    public class Permission
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Permission()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 是否允许编辑
        /// </summary>
        public bool Edit { get; set; } = true;
        /// <summary>
        /// 是否允许添加或修改标注
        /// </summary>
        public bool Annot { get; set; } = true;
        /// <summary>
        /// 是不允许导出
        /// </summary>
        public bool Export { get; set; } = true;
        /// <summary>
        /// 是否允许进行数字签名
        /// </summary>
        public bool Signature { get; set; } = true;
        /// <summary>
        /// 是否允许添加水印
        /// </summary>
        public bool Watermark { get; set; } = true;
        /// <summary>
        /// 是否允许截屏
        /// </summary>
        public bool PrintScreen { get; set; } = true;
        /// <summary>
        /// 打印权限，其具体的权限和份数设置由其属性 <see cref="Print.Printable"/> 及 <see cref="Print.Copics"/> 控制，若不设置 <see cref="Print"/> 节点，则默认为可以打印，并且打印份数不受限制
        /// </summary>
        public Print Print { get; set; }
        /// <summary>
        /// 有效期，即此文档允许访问的期限，期具体期限取决于开始日期和结束日期，其中开始日期不能晚于结束日期，并且开始日期和结束日期至少出现一个。当不设置开始日期时，代表不限定开始日期，当不设置结束日期时代表不限定结束日期；当此不设置此节点时，表示开始日期和结束日期均不受限
        /// </summary>
        public ValidPeriod ValidPeriod { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}