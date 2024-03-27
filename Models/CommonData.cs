using System;
using System.Collections.Generic;
using System.Text;
using XiaoFeng.Ofd.Attributes;
using XiaoFeng.Ofd.Internal;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 17:15:42                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Models
{
    /// <summary>
    /// 文件公共数据
    /// </summary>
    public class CommonData
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public CommonData()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 当前文档中所有对象使用标识的最大值，初始值为0。MaxUnitID主要用于文档编辑，在向文档中新增加一个对象时，需要分配一个新的标识 ，新的标识取值宜为MaxUnitID+1,同时需要修改此MaxUnitID值
        /// </summary>
        [Required]
        public STID MaxUnitID { get; set; }
        /// <summary>
        /// 指定该文档页面区域的默认大小和位置
        /// </summary>
        [Required] 
        public PageArea PageArea { get; set; }
        /// <summary>
        /// 公共资源序列，每个节点指向OFD包内一个资源描述文档，资源部分的描述见7.9，字体和颜色空间等宜在公共资源文件中描述
        /// </summary>
        public Location PublicRes { get; set; }
        /// <summary>
        /// 文档资源序列，每个节点指向OFD包内一个资源描述文档，资源部分的描述见7.9，绘制参数、多媒体和矢量图像等宜在文档资源文件中描述  
        /// </summary>
        public Location DocumentRes { get; set; }
        /// <summary>
        /// 模板页序列，为一系列模板页的集合，模板页内容结构和普通 页相同，描述见7.7
        /// </summary>
        public List<TemplatePage> TemplatePage { get; set; }
        /// <summary>
        /// 引用在资源文件中定义的颜色空间标识，有关颜色空间的描述见8.3.1。如果此贡不存在，采用RGB作为默认颜色空间
        /// </summary>
        public STRefID DefaultCS { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}