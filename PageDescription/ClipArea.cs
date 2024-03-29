using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.BaseType;
using XiaoFeng.Ofd.Fonts;
using XiaoFeng.Ofd.Graph;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-27 10:53:56                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.PageDescription
{
    /// <summary>
    /// 裁剪区域
    /// </summary>
    public class ClipArea
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public ClipArea()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 引用资源文件中的绘制参数的标识。线宽、结合点和端点样式等绘制特性对裁剪效果会产生影响，有关绘制参数的描述见8.2
        /// </summary>
        [XmlAttribute]
        public STRefID DrawParam { get; set; }
        /// <summary>
        /// 针对对象坐标系，对 <see cref="ClipArea"/> 下包含的 Path 和 Text 进行进一步的变换
        /// </summary>
        [XmlAttribute]
        public STArray CTM { get; set; }
        /// <summary>
        /// 用于裁剪的图形，见 <see langword="9.1"/> 图形对象
        /// </summary>
        public Path Path { get; set; }
        /// <summary>
        /// 用于裁剪的文本，见 <see langword="11.2"/> 文字对象
        /// </summary>
        public Text Text { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}