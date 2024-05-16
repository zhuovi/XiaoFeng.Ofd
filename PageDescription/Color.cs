using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.BaseType;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 21:10:10                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.PageDescription
{
    /// <summary>
    /// <para>颜色</para>
    /// <para>详情说明 见图 <see langword="25"/> ，见表 <see langword="26"/> </para>
    /// </summary>
    public class Color
    {
        #region 构造器
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        public Color() { }
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="index">调色板中颜色的编号,非负整数,将从当前颜色空间的调色板中取出相应索引的预定义颜色用来绘制。索引从0开始</param>
        /// <param name="value">颜色值,指定了当前颜色空间下各通道的取值。</param>
        public Color(int index, STArray value)
        {
            this.Index = index;
            this.Value = value;
        }
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="value">颜色值,指定了当前颜色空间下各通道的取值。</param>
        public Color(STArray value)
        {
            this.Value = value;
        }
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="index">调色板中颜色的编号,非负整数,将从当前颜色空间的调色板中取出相应索引的预定义颜色用来绘制。索引从0开始</param>
        /// <param name="values">颜色值,指定了当前颜色空间下各通道的取值。</param>
        public Color(int index,params object[] values)
        {
            this.Index = index;
            this.Value = values;
        }
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="values">颜色值,指定了当前颜色空间下各通道的取值。</param>
        public Color(params object[] values)
        {
            this.Value = values;
        }
        /// <summary>
        /// 初始化一个新实例
        /// </summary>
        /// <param name="r">RED 红</param>
        /// <param name="g">GREEN 绿</param>
        /// <param name="b">BLUE 蓝</param>
        public Color(int r,int g,int b)
        {
            this.Value = new STArray(r, g, b);
        }
        #endregion

        #region 属性
        /// <summary>
        /// 颜色值,指定了当前颜色空间下各通道的取值。Value的取值应符合"通道1通道2通道3…"格式。此属性不出现时,应采用Index属性从颜色空间的调色板中的取值。当二者都不出现时,该颜色各通道的值全部为0
        /// </summary>
        [XmlAttribute]
        public STArray Value { get; set; }
        /// <summary>
        /// 调色板中颜色的编号,非负整数,将从当前颜色空间的调色板中取出相应索引的预定义颜色用来绘制。索引从0开始
        /// </summary>
        [XmlAttribute]
        public int? Index { get; set; }
        /// <summary>
        /// 引用资源文件中颜色空间的标识，默认值为文档设定的颜色空间
        /// </summary>
        [XmlAttribute]
        public STRefID ColorSpace { get; set; }
        /// <summary>
        /// 颜色透明度,在0~255之间取值。默认为255,表示完全不透明
        /// </summary>
        [XmlAttribute]
        public int? Alpha { get; set; }
        /// <summary>
        /// 底纹填充，复杂颜色的一种。描述见8.3.3
        /// </summary>
        public Pattern Pattern { get; set; }
        /// <summary>
        /// 轴向渐变，复杂颜色的一种。描述见8.3.4.2
        /// </summary>
        public AxialShd AxialShd { get; set; }
        /// <summary>
        /// 径向渐变，复杂颜色的一种。描述见8.4.3
        /// </summary>
        public RadialShd RadialShd { get; set; }
        /// <summary>
        /// 高洛德渐变，复杂颜色的一种。描述见8.3.4.4
        /// </summary>
        public GouraudShd GouraudShd { get; set; }
        /// <summary>
        /// 格构高洛德渐变，复杂颜色的一种。描述见8.3.4.5
        /// </summary>
        public LaGouraudShd LaGouraudShd { get; set; }
        /// <summary>
        /// 浅粉红
        /// <para><term>16进制</term> <see langword="#FFB6C1"/></para>
        /// <para><term>RGB颜色值</term> <see langword="255,182,193"/></para>
        /// </summary>
        public static Color LightPink => new Color(255, 182, 193);
        /// <summary>
        /// 粉红
        /// <para><term>16进制</term> <see langword="#FFC0CB"/></para>
        /// <para><term>RGB颜色值</term> <see langword="255,192,203"/></para>
        /// </summary>
        public static Color Pink => new Color(255, 192, 203);
        /// <summary>
        /// 猩红
        /// <para><term>16进制</term> <see langword="#DC143C"/></para>
        /// <para><term>RGB颜色值</term> <see langword="220,20,60"/></para>
        /// </summary>
        public static Color Crimson => new Color(220, 20, 60);
        /// <summary>
        /// 脸红的淡紫色
        /// <para><term>16进制</term> <see langword="#FFF0F5"/></para>
        /// <para><term>RGB颜色值</term> <see langword="255,240,245"/></para>
        /// </summary>
        public static Color LavenderBlush => new Color(255, 240, 245);
        /// <summary>
        /// 苍白的紫罗兰红色
        /// <para><term>16进制</term> <see langword="#DB7093"/></para>
        /// <para><term>RGB颜色值</term> <see langword="219,112,147"/></para>
        /// </summary>
        public static Color PaleVioletRed => new Color(219, 112, 147);
        /// <summary>
        /// 热情的粉红
        /// <para><term>16进制</term> <see langword="#FF69B4"/></para>
        /// <para><term>RGB颜色值</term> <see langword="255,105,180"/></para>
        /// </summary>
        public static Color HotPink => new Color(255, 105, 180);
        /// <summary>
        /// 深粉色
        /// <para><term>16进制</term> <see langword="#FF1493"/></para>
        /// <para><term>RGB颜色值</term> <see langword="255,20,147"/></para>
        /// </summary>
        public static Color DeepPink => new Color(255, 20, 147);
        /// <summary>
        /// 适中的紫罗兰红色
        /// <para><term>16进制</term> <see langword="#C71585"/></para>
        /// <para><term>RGB颜色值</term> <see langword="199,21,133"/></para>
        /// </summary>
        public static Color MediumVioletRed => new Color(199, 21, 133);
        /// <summary>
        /// 兰花的紫色
        /// <para><term>16进制</term> <see langword="#DA70D6"/></para>
        /// <para><term>RGB颜色值</term> <see langword="218,112,214"/></para>
        /// </summary>
        public static Color Orchid => new Color(218, 112, 214);
        /// <summary>
        /// 蓟
        /// <para><term>16进制</term> <see langword="#D8BFD8"/></para>
        /// <para><term>RGB颜色值</term> <see langword="216,191,216"/></para>
        /// </summary>
        public static Color Thistle => new Color(216, 191, 216);
        /// <summary>
        /// 李子
        /// <para><term>16进制</term> <see langword="#DDA0DD"/></para>
        /// <para><term>RGB颜色值</term> <see langword="221,160,221"/></para>
        /// </summary>
        public static Color plum => new Color(221, 160, 221);
        /// <summary>
        /// 紫罗兰
        /// <para><term>16进制</term> <see langword="#EE82EE"/></para>
        /// <para><term>RGB颜色值</term> <see langword="238,130,238"/></para>
        /// </summary>
        public static Color Violet => new Color(238, 130, 238);
        /// <summary>
        /// 洋红
        /// <para><term>16进制</term> <see langword="#FF00FF"/></para>
        /// <para><term>RGB颜色值</term> <see langword="255,0,255"/></para>
        /// </summary>
        public static Color Magenta => new Color(255, 0, 255);
        /// <summary>
        /// 灯笼海棠(紫红色)
        /// <para><term>16进制</term> <see langword="#FF00FF"/></para>
        /// <para><term>RGB颜色值</term> <see langword="255,0,255"/></para>
        /// </summary>
        public static Color Fuchsia => new Color(255, 0, 255);
        /// <summary>
        /// 深洋红色
        /// <para><term>16进制</term> <see langword="#8B008B"/></para>
        /// <para><term>RGB颜色值</term> <see langword="139,0,139"/></para>
        /// </summary>
        public static Color DarkMagenta => new Color(139, 0, 139);
        /// <summary>
        /// 紫色
        /// <para><term>16进制</term> <see langword="#800080"/></para>
        /// <para><term>RGB颜色值</term> <see langword="128,0,128"/></para>
        /// </summary>
        public static Color Purple => new Color(128, 0, 128);
        /// <summary>
        /// 适中的兰花紫
        /// <para><term>16进制</term> <see langword="#BA55D3"/></para>
        /// <para><term>RGB颜色值</term> <see langword="186,85,211"/></para>
        /// </summary>
        public static Color MediumOrchid => new Color(186, 85, 211);
        /// <summary>
        /// 深紫罗兰色
        /// <para><term>16进制</term> <see langword="#9400D3"/></para>
        /// <para><term>RGB颜色值</term> <see langword="148,0,211"/></para>
        /// </summary>
        public static Color DarkVoilet => new Color(148, 0, 211);
        /// <summary>
        /// 深兰花紫
        /// <para><term>16进制</term> <see langword="#9932CC"/></para>
        /// <para><term>RGB颜色值</term> <see langword="153,50,204"/></para>
        /// </summary>
        public static Color DarkOrchid => new Color(153, 50, 204);
        /// <summary>
        /// 靛青
        /// <para><term>16进制</term> <see langword="#4B0082"/></para>
        /// <para><term>RGB颜色值</term> <see langword="75,0,130"/></para>
        /// </summary>
        public static Color Indigo => new Color(75, 0, 130);
        /// <summary>
        /// 深紫罗兰的蓝色
        /// <para><term>16进制</term> <see langword="#8A2BE2"/></para>
        /// <para><term>RGB颜色值</term> <see langword="138,43,226"/></para>
        /// </summary>
        public static Color BlueViolet => new Color(138, 43, 226);
        /// <summary>
        /// 适中的紫色
        /// <para><term>16进制</term> <see langword="#9370DB"/></para>
        /// <para><term>RGB颜色值</term> <see langword="147,112,219"/></para>
        /// </summary>
        public static Color MediumPurple => new Color(147, 112, 219);
        /// <summary>
        /// 适中的板岩暗蓝灰色
        /// <para><term>16进制</term> <see langword="#7B68EE"/></para>
        /// <para><term>RGB颜色值</term> <see langword="123,104,238"/></para>
        /// </summary>
        public static Color MediumSlateBlue => new Color(123, 104, 238);
        /// <summary>
        /// 板岩暗蓝灰色
        /// <para><term>16进制</term> <see langword="#6A5ACD"/></para>
        /// <para><term>RGB颜色值</term> <see langword="106,90,205"/></para>
        /// </summary>
        public static Color SlateBlue => new Color(106, 90, 205);
        /// <summary>
        /// 深岩暗蓝灰色
        /// <para><term>16进制</term> <see langword="#483D8B"/></para>
        /// <para><term>RGB颜色值</term> <see langword="72,61,139"/></para>
        /// </summary>
        public static Color DarkSlateBlue => new Color(72, 61, 139);
        /// <summary>
        /// 熏衣草花的淡紫色
        /// <para><term>16进制</term> <see langword="#E6E6FA"/></para>
        /// <para><term>RGB颜色值</term> <see langword="230,230,250"/></para>
        /// </summary>
        public static Color Lavender => new Color(230, 230, 250);
        /// <summary>
        /// 幽灵的白色
        /// <para><term>16进制</term> <see langword="#F8F8FF"/></para>
        /// <para><term>RGB颜色值</term> <see langword="248,248,255"/></para>
        /// </summary>
        public static Color GhostWhite => new Color(248, 248, 255);
        /// <summary>
        /// 蓝色
        /// <para><term>16进制</term> <see langword="#0000FF"/></para>
        /// <para><term>RGB颜色值</term> <see langword="0,0,255"/></para>
        /// </summary>
        public static Color Blue => new Color(0, 0, 255);
        /// <summary>
        /// 适中的蓝色
        /// <para><term>16进制</term> <see langword="#0000CD"/></para>
        /// <para><term>RGB颜色值</term> <see langword="0,0,205"/></para>
        /// </summary>
        public static Color MediumBlue => new Color(0, 0, 205);
        /// <summary>
        /// 午夜的蓝色
        /// <para><term>16进制</term> <see langword="#191970"/></para>
        /// <para><term>RGB颜色值</term> <see langword="25,25,112"/></para>
        /// </summary>
        public static Color MidnightBlue => new Color(25, 25, 112);
        /// <summary>
        /// 深蓝色
        /// <para><term>16进制</term> <see langword="#00008B"/></para>
        /// <para><term>RGB颜色值</term> <see langword="0,0,139"/></para>
        /// </summary>
        public static Color DarkBlue => new Color(0, 0, 139);
        /// <summary>
        /// 海军蓝
        /// <para><term>16进制</term> <see langword="#000080"/></para>
        /// <para><term>RGB颜色值</term> <see langword="0,0,128"/></para>
        /// </summary>
        public static Color Navy => new Color(0, 0, 128);
        /// <summary>
        /// 皇家蓝
        /// <para><term>16进制</term> <see langword="#4169E1"/></para>
        /// <para><term>RGB颜色值</term> <see langword="65,105,225"/></para>
        /// </summary>
        public static Color RoyalBlue => new Color(65, 105, 225);
        /// <summary>
        /// 矢车菊的蓝色
        /// <para><term>16进制</term> <see langword="#6495ED"/></para>
        /// <para><term>RGB颜色值</term> <see langword="100,149,237"/></para>
        /// </summary>
        public static Color CornflowerBlue => new Color(100, 149, 237);
        /// <summary>
        /// 淡钢蓝
        /// <para><term>16进制</term> <see langword="#B0C4DE"/></para>
        /// <para><term>RGB颜色值</term> <see langword="176,196,222"/></para>
        /// </summary>
        public static Color LightSteelBlue => new Color(176, 196, 222);
        /// <summary>
        /// 浅石板灰
        /// <para><term>16进制</term> <see langword="#778899"/></para>
        /// <para><term>RGB颜色值</term> <see langword="119,136,153"/></para>
        /// </summary>
        public static Color LightSlateGray => new Color(119, 136, 153);
        /// <summary>
        /// 石板灰
        /// <para><term>16进制</term> <see langword="#708090"/></para>
        /// <para><term>RGB颜色值</term> <see langword="112,128,144"/></para>
        /// </summary>
        public static Color SlateGray => new Color(112, 128, 144);
        /// <summary>
        /// 道奇蓝
        /// <para><term>16进制</term> <see langword="#1E90FF"/></para>
        /// <para><term>RGB颜色值</term> <see langword="30,144,255"/></para>
        /// </summary>
        public static Color DoderBlue => new Color(30, 144, 255);
        /// <summary>
        /// 爱丽丝蓝
        /// <para><term>16进制</term> <see langword="#F0F8FF"/></para>
        /// <para><term>RGB颜色值</term> <see langword="240,248,255"/></para>
        /// </summary>
        public static Color AliceBlue => new Color(240, 248, 255);
        /// <summary>
        /// 钢蓝
        /// <para><term>16进制</term> <see langword="#4682B4"/></para>
        /// <para><term>RGB颜色值</term> <see langword="70,130,180"/></para>
        /// </summary>
        public static Color SteelBlue => new Color(70, 130, 180);
        /// <summary>
        /// 淡蓝色
        /// <para><term>16进制</term> <see langword="#87CEFA"/></para>
        /// <para><term>RGB颜色值</term> <see langword="135,206,250"/></para>
        /// </summary>
        public static Color LightSkyBlue => new Color(135, 206, 250);
        /// <summary>
        /// 天蓝色
        /// <para><term>16进制</term> <see langword="#87CEEB"/></para>
        /// <para><term>RGB颜色值</term> <see langword="135,206,235"/></para>
        /// </summary>
        public static Color SkyBlue => new Color(135, 206, 235);
        /// <summary>
        /// 深天蓝
        /// <para><term>16进制</term> <see langword="#00BFFF"/></para>
        /// <para><term>RGB颜色值</term> <see langword="0,191,255"/></para>
        /// </summary>
        public static Color DeepSkyBlue => new Color(0, 191, 255);
        /// <summary>
        /// 淡蓝
        /// <para><term>16进制</term> <see langword="#ADD8E6"/></para>
        /// <para><term>RGB颜色值</term> <see langword="173,216,230"/></para>
        /// </summary>
        public static Color LightBLue => new Color(173, 216, 230);
        /// <summary>
        /// 火药蓝
        /// <para><term>16进制</term> <see langword="#B0E0E6"/></para>
        /// <para><term>RGB颜色值</term> <see langword="176,224,230"/></para>
        /// </summary>
        public static Color PowDerBlue => new Color(176, 224, 230);
        /// <summary>
        /// 军校蓝
        /// <para><term>16进制</term> <see langword="#5F9EA0"/></para>
        /// <para><term>RGB颜色值</term> <see langword="95,158,160"/></para>
        /// </summary>
        public static Color CadetBlue => new Color(95, 158, 160);
        /// <summary>
        /// 蔚蓝色
        /// <para><term>16进制</term> <see langword="#F0FFFF"/></para>
        /// <para><term>RGB颜色值</term> <see langword="240,255,255"/></para>
        /// </summary>
        public static Color Azure => new Color(240, 255, 255);
        /// <summary>
        /// 淡青色
        /// <para><term>16进制</term> <see langword="#E1FFFF"/></para>
        /// <para><term>RGB颜色值</term> <see langword="225,255,255"/></para>
        /// </summary>
        public static Color LightCyan => new Color(225, 255, 255);
        /// <summary>
        /// 苍白的绿宝石
        /// <para><term>16进制</term> <see langword="#AFEEEE"/></para>
        /// <para><term>RGB颜色值</term> <see langword="175,238,238"/></para>
        /// </summary>
        public static Color PaleTurquoise => new Color(175, 238, 238);
        /// <summary>
        /// 青色
        /// <para><term>16进制</term> <see langword="#00FFFF"/></para>
        /// <para><term>RGB颜色值</term> <see langword="0,255,255"/></para>
        /// </summary>
        public static Color Cyan => new Color(0, 255, 255);
        /// <summary>
        /// 水绿色
        /// <para><term>16进制</term> <see langword="#D4F2E7"/></para>
        /// <para><term>RGB颜色值</term> <see langword="212,242,231"/></para>
        /// </summary>
        public static Color Aqua => new Color(212, 242, 231);
        /// <summary>
        /// 深绿宝石
        /// <para><term>16进制</term> <see langword="#00CED1"/></para>
        /// <para><term>RGB颜色值</term> <see langword="0,206,209"/></para>
        /// </summary>
        public static Color DarkTurquoise => new Color(0, 206, 209);
        /// <summary>
        /// 深石板灰
        /// <para><term>16进制</term> <see langword="#2F4F4F"/></para>
        /// <para><term>RGB颜色值</term> <see langword="47,79,79"/></para>
        /// </summary>
        public static Color DarkSlateGray => new Color(47, 79, 79);
        /// <summary>
        /// 深青色
        /// <para><term>16进制</term> <see langword="#008B8B"/></para>
        /// <para><term>RGB颜色值</term> <see langword="0,139,139"/></para>
        /// </summary>
        public static Color DarkCyan => new Color(0, 139, 139);
        /// <summary>
        /// 水鸭色
        /// <para><term>16进制</term> <see langword="#008080"/></para>
        /// <para><term>RGB颜色值</term> <see langword="0,128,128"/></para>
        /// </summary>
        public static Color Teal => new Color(0, 128, 128);
        /// <summary>
        /// 适中的绿宝石
        /// <para><term>16进制</term> <see langword="#48D1CC"/></para>
        /// <para><term>RGB颜色值</term> <see langword="72,209,204"/></para>
        /// </summary>
        public static Color MediumTurquoise => new Color(72, 209, 204);
        /// <summary>
        /// 浅海洋绿
        /// <para><term>16进制</term> <see langword="#20B2AA"/></para>
        /// <para><term>RGB颜色值</term> <see langword="32,178,170"/></para>
        /// </summary>
        public static Color LightSeaGreen => new Color(32, 178, 170);
        /// <summary>
        /// 绿宝石
        /// <para><term>16进制</term> <see langword="#40E0D0"/></para>
        /// <para><term>RGB颜色值</term> <see langword="64,224,208"/></para>
        /// </summary>
        public static Color Turquoise => new Color(64, 224, 208);
        /// <summary>
        /// 绿玉\碧绿色
        /// <para><term>16进制</term> <see langword="#7FFFAA"/></para>
        /// <para><term>RGB颜色值</term> <see langword="127,255,170"/></para>
        /// </summary>
        public static Color Auqamarin => new Color(127, 255, 170);
        /// <summary>
        /// 适中的碧绿色
        /// <para><term>16进制</term> <see langword="#00FA9A"/></para>
        /// <para><term>RGB颜色值</term> <see langword="0,250,154"/></para>
        /// </summary>
        public static Color MediumAquamarine => new Color(0, 250, 154);
        /// <summary>
        /// 适中的春天的绿色
        /// <para><term>16进制</term> <see langword="#00FF7F"/></para>
        /// <para><term>RGB颜色值</term> <see langword="0,255,127"/></para>
        /// </summary>
        public static Color MediumSpringGreen => new Color(0, 255, 127);
        /// <summary>
        /// 薄荷奶油
        /// <para><term>16进制</term> <see langword="#F5FFFA"/></para>
        /// <para><term>RGB颜色值</term> <see langword="245,255,250"/></para>
        /// </summary>
        public static Color MintCream => new Color(245, 255, 250);
        /// <summary>
        /// 春天的绿色
        /// <para><term>16进制</term> <see langword="#3CB371"/></para>
        /// <para><term>RGB颜色值</term> <see langword="60,179,113"/></para>
        /// </summary>
        public static Color SpringGreen => new Color(60, 179, 113);
        /// <summary>
        /// 海洋绿
        /// <para><term>16进制</term> <see langword="#2E8B57"/></para>
        /// <para><term>RGB颜色值</term> <see langword="46,139,87"/></para>
        /// </summary>
        public static Color SeaGreen => new Color(46, 139, 87);
        /// <summary>
        /// 蜂蜜
        /// <para><term>16进制</term> <see langword="#F0FFF0"/></para>
        /// <para><term>RGB颜色值</term> <see langword="240,255,240"/></para>
        /// </summary>
        public static Color Honeydew => new Color(240, 255, 240);
        /// <summary>
        /// 淡绿色
        /// <para><term>16进制</term> <see langword="#90EE90"/></para>
        /// <para><term>RGB颜色值</term> <see langword="144,238,144"/></para>
        /// </summary>
        public static Color LightGreen => new Color(144, 238, 144);
        /// <summary>
        /// 苍白的绿色
        /// <para><term>16进制</term> <see langword="#98FB98"/></para>
        /// <para><term>RGB颜色值</term> <see langword="152,251,152"/></para>
        /// </summary>
        public static Color PaleGreen => new Color(152, 251, 152);
        /// <summary>
        /// 深海洋绿
        /// <para><term>16进制</term> <see langword="#8FBC8F"/></para>
        /// <para><term>RGB颜色值</term> <see langword="143,188,143"/></para>
        /// </summary>
        public static Color DarkSeaGreen => new Color(143, 188, 143);
        /// <summary>
        /// 酸橙绿
        /// <para><term>16进制</term> <see langword="#32CD32"/></para>
        /// <para><term>RGB颜色值</term> <see langword="50,205,50"/></para>
        /// </summary>
        public static Color LimeGreen => new Color(50, 205, 50);
        /// <summary>
        /// 酸橙色
        /// <para><term>16进制</term> <see langword="#00FF00"/></para>
        /// <para><term>RGB颜色值</term> <see langword="0,255,0"/></para>
        /// </summary>
        public static Color Lime => new Color(0, 255, 0);
        /// <summary>
        /// 森林绿
        /// <para><term>16进制</term> <see langword="#228B22"/></para>
        /// <para><term>RGB颜色值</term> <see langword="34,139,34"/></para>
        /// </summary>
        public static Color ForestGreen => new Color(34, 139, 34);
        /// <summary>
        /// 绿色
        /// <para><term>16进制</term> <see langword="#008000"/></para>
        /// <para><term>RGB颜色值</term> <see langword="0,128,0"/></para>
        /// </summary>
        public static Color Green => new Color(0, 128, 0);
        /// <summary>
        /// 深绿色
        /// <para><term>16进制</term> <see langword="#006400"/></para>
        /// <para><term>RGB颜色值</term> <see langword="0,100,0"/></para>
        /// </summary>
        public static Color DarkGreen => new Color(0, 100, 0);
        /// <summary>
        /// 查特酒绿
        /// <para><term>16进制</term> <see langword="#7FFF00"/></para>
        /// <para><term>RGB颜色值</term> <see langword="127,255,0"/></para>
        /// </summary>
        public static Color Chartreuse => new Color(127, 255, 0);
        /// <summary>
        /// 草坪绿
        /// <para><term>16进制</term> <see langword="#7CFC00"/></para>
        /// <para><term>RGB颜色值</term> <see langword="124,252,0"/></para>
        /// </summary>
        public static Color LawnGreen => new Color(124, 252, 0);
        /// <summary>
        /// 绿黄色
        /// <para><term>16进制</term> <see langword="#ADFF2F"/></para>
        /// <para><term>RGB颜色值</term> <see langword="173,255,47"/></para>
        /// </summary>
        public static Color GreenYellow => new Color(173, 255, 47);
        /// <summary>
        /// 橄榄土褐色
        /// <para><term>16进制</term> <see langword="#556B2F"/></para>
        /// <para><term>RGB颜色值</term> <see langword="85,107,47"/></para>
        /// </summary>
        public static Color OliveDrab => new Color(85, 107, 47);
        /// <summary>
        /// 米色(浅褐色)
        /// <para><term>16进制</term> <see langword="#F5F5DC"/></para>
        /// <para><term>RGB颜色值</term> <see langword="245,245,220"/></para>
        /// </summary>
        public static Color Beige => new Color(245, 245, 220);
        /// <summary>
        /// 浅秋麒麟黄
        /// <para><term>16进制</term> <see langword="#FAFAD2"/></para>
        /// <para><term>RGB颜色值</term> <see langword="250,250,210"/></para>
        /// </summary>
        public static Color LightGoldenrodYellow => new Color(250, 250, 210);
        /// <summary>
        /// 象牙
        /// <para><term>16进制</term> <see langword="#FFFFF0"/></para>
        /// <para><term>RGB颜色值</term> <see langword="255,255,240"/></para>
        /// </summary>
        public static Color Ivory => new Color(255, 255, 240);
        /// <summary>
        /// 浅黄色
        /// <para><term>16进制</term> <see langword="#FFFFE0"/></para>
        /// <para><term>RGB颜色值</term> <see langword="255,255,224"/></para>
        /// </summary>
        public static Color LightYellow => new Color(255, 255, 224);
        /// <summary>
        /// 黄色
        /// <para><term>16进制</term> <see langword="#FFFF00"/></para>
        /// <para><term>RGB颜色值</term> <see langword="255,255,0"/></para>
        /// </summary>
        public static Color Yellow => new Color(255, 255, 0);
        /// <summary>
        /// 橄榄
        /// <para><term>16进制</term> <see langword="#808000"/></para>
        /// <para><term>RGB颜色值</term> <see langword="128,128,0"/></para>
        /// </summary>
        public static Color Olive => new Color(128, 128, 0);
        /// <summary>
        /// 深卡其布
        /// <para><term>16进制</term> <see langword="#BDB76B"/></para>
        /// <para><term>RGB颜色值</term> <see langword="189,183,107"/></para>
        /// </summary>
        public static Color DarkKhaki => new Color(189, 183, 107);
        /// <summary>
        /// 柠檬薄纱
        /// <para><term>16进制</term> <see langword="#FFFACD"/></para>
        /// <para><term>RGB颜色值</term> <see langword="255,250,205"/></para>
        /// </summary>
        public static Color LemonChiffon => new Color(255, 250, 205);
        /// <summary>
        /// 灰秋麒麟
        /// <para><term>16进制</term> <see langword="#EEE8AA"/></para>
        /// <para><term>RGB颜色值</term> <see langword="238,232,170"/></para>
        /// </summary>
        public static Color PaleGodenrod => new Color(238, 232, 170);
        /// <summary>
        /// 卡其布
        /// <para><term>16进制</term> <see langword="#F0E68C"/></para>
        /// <para><term>RGB颜色值</term> <see langword="240,230,140"/></para>
        /// </summary>
        public static Color Khaki => new Color(240, 230, 140);
        /// <summary>
        /// 金
        /// <para><term>16进制</term> <see langword="#FFD700"/></para>
        /// <para><term>RGB颜色值</term> <see langword="255,215,0"/></para>
        /// </summary>
        public static Color Gold => new Color(255, 215, 0);
        /// <summary>
        /// 玉米色
        /// <para><term>16进制</term> <see langword="#FFF8DC"/></para>
        /// <para><term>RGB颜色值</term> <see langword="255,248,220"/></para>
        /// </summary>
        public static Color Cornislk => new Color(255, 248, 220);
        /// <summary>
        /// 秋麒麟
        /// <para><term>16进制</term> <see langword="#DAA520"/></para>
        /// <para><term>RGB颜色值</term> <see langword="218,165,32"/></para>
        /// </summary>
        public static Color GoldEnrod => new Color(218, 165, 32);
        /// <summary>
        /// 花的白色
        /// <para><term>16进制</term> <see langword="#FFFAF0"/></para>
        /// <para><term>RGB颜色值</term> <see langword="255,250,240"/></para>
        /// </summary>
        public static Color FloralWhite => new Color(255, 250, 240);
        /// <summary>
        /// 老饰带
        /// <para><term>16进制</term> <see langword="#FDF5E6"/></para>
        /// <para><term>RGB颜色值</term> <see langword="253,245,230"/></para>
        /// </summary>
        public static Color OldLace => new Color(253, 245, 230);
        /// <summary>
        /// 小麦色
        /// <para><term>16进制</term> <see langword="#F5DEB3"/></para>
        /// <para><term>RGB颜色值</term> <see langword="245,222,179"/></para>
        /// </summary>
        public static Color Wheat => new Color(245, 222, 179);
        /// <summary>
        /// 鹿皮鞋
        /// <para><term>16进制</term> <see langword="#FFE4B5"/></para>
        /// <para><term>RGB颜色值</term> <see langword="255,228,181"/></para>
        /// </summary>
        public static Color Moccasin => new Color(255, 228, 181);
        /// <summary>
        /// 橙色
        /// <para><term>16进制</term> <see langword="#FFA500"/></para>
        /// <para><term>RGB颜色值</term> <see langword="255,165,0"/></para>
        /// </summary>
        public static Color Orange => new Color(255, 165, 0);
        /// <summary>
        /// 番木瓜
        /// <para><term>16进制</term> <see langword="#FFEFD5"/></para>
        /// <para><term>RGB颜色值</term> <see langword="255,239,213"/></para>
        /// </summary>
        public static Color PapayaWhip => new Color(255, 239, 213);
        /// <summary>
        /// 漂白的杏仁
        /// <para><term>16进制</term> <see langword="#FFEBCD"/></para>
        /// <para><term>RGB颜色值</term> <see langword="255,235,205"/></para>
        /// </summary>
        public static Color BlanchedAlmond => new Color(255, 235, 205);
        /// <summary>
        /// 纳瓦霍白
        /// <para><term>16进制</term> <see langword="#FFDEAD"/></para>
        /// <para><term>RGB颜色值</term> <see langword="255,222,173"/></para>
        /// </summary>
        public static Color NavajoWhite => new Color(255, 222, 173);
        /// <summary>
        /// 古代的白色
        /// <para><term>16进制</term> <see langword="#FAEBD7"/></para>
        /// <para><term>RGB颜色值</term> <see langword="250,235,215"/></para>
        /// </summary>
        public static Color AntiqueWhite => new Color(250, 235, 215);
        /// <summary>
        /// 晒黑
        /// <para><term>16进制</term> <see langword="#D2B48C"/></para>
        /// <para><term>RGB颜色值</term> <see langword="210,180,140"/></para>
        /// </summary>
        public static Color Tan => new Color(210, 180, 140);
        /// <summary>
        /// 结实的树
        /// <para><term>16进制</term> <see langword="#DEB887"/></para>
        /// <para><term>RGB颜色值</term> <see langword="222,184,135"/></para>
        /// </summary>
        public static Color BrulyWood => new Color(222, 184, 135);
        /// <summary>
        /// (浓汤)乳脂,番茄等
        /// <para><term>16进制</term> <see langword="#FFE4C4"/></para>
        /// <para><term>RGB颜色值</term> <see langword="255,228,196"/></para>
        /// </summary>
        public static Color Bisque => new Color(255, 228, 196);
        /// <summary>
        /// 深橙色
        /// <para><term>16进制</term> <see langword="#FF8C00"/></para>
        /// <para><term>RGB颜色值</term> <see langword="255,140,0"/></para>
        /// </summary>
        public static Color DarkOrange => new Color(255, 140, 0);
        /// <summary>
        /// 亚麻布
        /// <para><term>16进制</term> <see langword="#FAF0E6"/></para>
        /// <para><term>RGB颜色值</term> <see langword="250,240,230"/></para>
        /// </summary>
        public static Color Linen => new Color(250, 240, 230);
        /// <summary>
        /// 秘鲁
        /// <para><term>16进制</term> <see langword="#CD853F"/></para>
        /// <para><term>RGB颜色值</term> <see langword="205,133,63"/></para>
        /// </summary>
        public static Color Peru => new Color(205, 133, 63);
        /// <summary>
        /// 桃色
        /// <para><term>16进制</term> <see langword="#FFDAB9"/></para>
        /// <para><term>RGB颜色值</term> <see langword="255,218,185"/></para>
        /// </summary>
        public static Color PeachPuff => new Color(255, 218, 185);
        /// <summary>
        /// 沙棕色
        /// <para><term>16进制</term> <see langword="#F4A460"/></para>
        /// <para><term>RGB颜色值</term> <see langword="244,164,96"/></para>
        /// </summary>
        public static Color SandyBrown => new Color(244, 164, 96);
        /// <summary>
        /// 巧克力
        /// <para><term>16进制</term> <see langword="#D2691E"/></para>
        /// <para><term>RGB颜色值</term> <see langword="210,105,30"/></para>
        /// </summary>
        public static Color Chocolate => new Color(210, 105, 30);
        /// <summary>
        /// 马鞍棕色
        /// <para><term>16进制</term> <see langword="#8B4513"/></para>
        /// <para><term>RGB颜色值</term> <see langword="139,69,19"/></para>
        /// </summary>
        public static Color SaddleBrown => new Color(139, 69, 19);
        /// <summary>
        /// 海贝壳
        /// <para><term>16进制</term> <see langword="#FFF5EE"/></para>
        /// <para><term>RGB颜色值</term> <see langword="255,245,238"/></para>
        /// </summary>
        public static Color SeaShell => new Color(255, 245, 238);
        /// <summary>
        /// 黄土赭色
        /// <para><term>16进制</term> <see langword="#A0522D"/></para>
        /// <para><term>RGB颜色值</term> <see langword="160,82,45"/></para>
        /// </summary>
        public static Color Sienna => new Color(160, 82, 45);
        /// <summary>
        /// 浅鲜肉(鲑鱼)色
        /// <para><term>16进制</term> <see langword="#FFA07A"/></para>
        /// <para><term>RGB颜色值</term> <see langword="255,160,122"/></para>
        /// </summary>
        public static Color LightSalmon => new Color(255, 160, 122);
        /// <summary>
        /// 珊瑚
        /// <para><term>16进制</term> <see langword="#FF7F50"/></para>
        /// <para><term>RGB颜色值</term> <see langword="255,127,80"/></para>
        /// </summary>
        public static Color Coral => new Color(255, 127, 80);
        /// <summary>
        /// 橙红色
        /// <para><term>16进制</term> <see langword="#FF4500"/></para>
        /// <para><term>RGB颜色值</term> <see langword="255,69,0"/></para>
        /// </summary>
        public static Color OrangeRed => new Color(255, 69, 0);
        /// <summary>
        /// 深鲜肉(鲑鱼)色
        /// <para><term>16进制</term> <see langword="#E9967A"/></para>
        /// <para><term>RGB颜色值</term> <see langword="233,150,122"/></para>
        /// </summary>
        public static Color DarkSalmon => new Color(233, 150, 122);
        /// <summary>
        /// 番茄
        /// <para><term>16进制</term> <see langword="#FF6347"/></para>
        /// <para><term>RGB颜色值</term> <see langword="255,99,71"/></para>
        /// </summary>
        public static Color Tomato => new Color(255, 99, 71);
        /// <summary>
        /// 薄雾玫瑰
        /// <para><term>16进制</term> <see langword="#FFE4E1"/></para>
        /// <para><term>RGB颜色值</term> <see langword="255,228,225"/></para>
        /// </summary>
        public static Color MistyRose => new Color(255, 228, 225);
        /// <summary>
        /// 鲜肉(鲑鱼)色
        /// <para><term>16进制</term> <see langword="#FA8072"/></para>
        /// <para><term>RGB颜色值</term> <see langword="250,128,114"/></para>
        /// </summary>
        public static Color Salmon => new Color(250, 128, 114);
        /// <summary>
        /// 雪
        /// <para><term>16进制</term> <see langword="#FFFAFA"/></para>
        /// <para><term>RGB颜色值</term> <see langword="255,250,250"/></para>
        /// </summary>
        public static Color Snow => new Color(255, 250, 250);
        /// <summary>
        /// 淡珊瑚色
        /// <para><term>16进制</term> <see langword="#F08080"/></para>
        /// <para><term>RGB颜色值</term> <see langword="240,128,128"/></para>
        /// </summary>
        public static Color LightCoral => new Color(240, 128, 128);
        /// <summary>
        /// 玫瑰棕色
        /// <para><term>16进制</term> <see langword="#BC8F8F"/></para>
        /// <para><term>RGB颜色值</term> <see langword="188,143,143"/></para>
        /// </summary>
        public static Color RosyBrown => new Color(188, 143, 143);
        /// <summary>
        /// 印度红
        /// <para><term>16进制</term> <see langword="#CD5C5C"/></para>
        /// <para><term>RGB颜色值</term> <see langword="205,92,92"/></para>
        /// </summary>
        public static Color IndianRed => new Color(205, 92, 92);
        /// <summary>
        /// 红色
        /// <para><term>16进制</term> <see langword="#FF0000"/></para>
        /// <para><term>RGB颜色值</term> <see langword="255,0,0"/></para>
        /// </summary>
        public static Color Red => new Color(255, 0, 0);
        /// <summary>
        /// 棕色
        /// <para><term>16进制</term> <see langword="#A52A2A"/></para>
        /// <para><term>RGB颜色值</term> <see langword="165,42,42"/></para>
        /// </summary>
        public static Color Brown => new Color(165, 42, 42);
        /// <summary>
        /// 耐火砖
        /// <para><term>16进制</term> <see langword="#B22222"/></para>
        /// <para><term>RGB颜色值</term> <see langword="178,34,34"/></para>
        /// </summary>
        public static Color FireBrick => new Color(178, 34, 34);
        /// <summary>
        /// 深红色
        /// <para><term>16进制</term> <see langword="#8B0000"/></para>
        /// <para><term>RGB颜色值</term> <see langword="139,0,0"/></para>
        /// </summary>
        public static Color DarkRed => new Color(139, 0, 0);
        /// <summary>
        /// 栗色
        /// <para><term>16进制</term> <see langword="#800000"/></para>
        /// <para><term>RGB颜色值</term> <see langword="128,0,0"/></para>
        /// </summary>
        public static Color Maroon => new Color(128, 0, 0);
        /// <summary>
        /// 白色
        /// <para><term>16进制</term> <see langword="#FFFFFF"/></para>
        /// <para><term>RGB颜色值</term> <see langword="255,255,255"/></para>
        /// </summary>
        public static Color White => new Color(255, 255, 255);
        /// <summary>
        /// 白烟
        /// <para><term>16进制</term> <see langword="#F5F5F5"/></para>
        /// <para><term>RGB颜色值</term> <see langword="245,245,245"/></para>
        /// </summary>
        public static Color WhiteSmoke => new Color(245, 245, 245);
        /// <summary>
        /// 亮灰色
        /// <para><term>16进制</term> <see langword="#DCDCDC"/></para>
        /// <para><term>RGB颜色值</term> <see langword="220,220,220"/></para>
        /// </summary>
        public static Color Gainsboro => new Color(220, 220, 220);
        /// <summary>
        /// 浅灰色
        /// <para><term>16进制</term> <see langword="#D3D3D3"/></para>
        /// <para><term>RGB颜色值</term> <see langword="211,211,211"/></para>
        /// </summary>
        public static Color LightGrey => new Color(211, 211, 211);
        /// <summary>
        /// 银白色
        /// <para><term>16进制</term> <see langword="#C0C0C0"/></para>
        /// <para><term>RGB颜色值</term> <see langword="192,192,192"/></para>
        /// </summary>
        public static Color Silver => new Color(192, 192, 192);
        /// <summary>
        /// 深灰色
        /// <para><term>16进制</term> <see langword="#A9A9A9"/></para>
        /// <para><term>RGB颜色值</term> <see langword="169,169,169"/></para>
        /// </summary>
        public static Color DarkGray => new Color(169, 169, 169);
        /// <summary>
        /// 灰色
        /// <para><term>16进制</term> <see langword="#808080"/></para>
        /// <para><term>RGB颜色值</term> <see langword="128,128,128"/></para>
        /// </summary>
        public static Color Gray => new Color(128, 128, 128);
        /// <summary>
        /// 暗淡的灰色
        /// <para><term>16进制</term> <see langword="#696969"/></para>
        /// <para><term>RGB颜色值</term> <see langword="105,105,105"/></para>
        /// </summary>
        public static Color DimGray => new Color(105, 105, 105);
        /// <summary>
        /// 黑色
        /// <para><term>16进制</term> <see langword="#000000"/></para>
        /// <para><term>RGB颜色值</term> <see langword="0,0,0"/></para>
        /// </summary>
        public static Color Black => new Color(0, 0, 0);

        #endregion

        #region 方法
        ///<inheritdoc/>
        public override string ToString()
        {
            return $"{this.Value}";
        }
        #endregion
    }
}