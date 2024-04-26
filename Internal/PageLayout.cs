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
*  Create Time : 2024-04-23 08:56:33                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Internal
{
    /// <summary>
    /// 页面配置
    /// </summary>
    public class PageLayout
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public PageLayout()
        {

        }
        #endregion

        #region 属性
        public float Width { get; set; }
        public float Height { get; set; }
        public float MarginLeft { get; set; }
        public float MarginTop { get; set; }
        public float MarginRight { get; set; }
        public float MarginBottom { get; set; }
        
        #endregion

        #region 方法
        public PageArea GetPageArea()
        {
            return new PageArea()
            {
                 PhysicalBox=new BaseType.Box(0,0,this.Width, this.Height),

            };
        }
        #endregion
    }
}