![fayelf](https://user-images.githubusercontent.com/16105174/197918392-29d40971-a8a2-4be4-ac17-323f1d0bed82.png)

![GitHub top language](https://img.shields.io/github/languages/top/zhuovi/xiaofeng.ofd?logo=github)
![GitHub License](https://img.shields.io/github/license/zhuovi/xiaofeng.ofd?logo=github)
![Nuget Downloads](https://img.shields.io/nuget/dt/xiaofeng.ofd?logo=nuget)
![Nuget](https://img.shields.io/nuget/v/xiaofeng.ofd?logo=nuget)
![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/xiaofeng.ofd?label=dev%20nuget&logo=nuget)

Nuget：XiaoFeng.Ofd

| QQ群号 | QQ群 | 公众号 |
| :----:| :----: | :----: |
| 748408911  | ![QQ 群](https://user-images.githubusercontent.com/16105174/198058269-0ea5928c-a2fc-4049-86da-cca2249229ae.png) | ![畅聊了个科技](https://user-images.githubusercontent.com/16105174/198059698-adbf29c3-60c2-4c76-b894-21793b40cf34.jpg) |


源码： https://github.com/zhuovi/xiaofeng.ofd

教程： https://www.eelf.cn

OFD 读写处理库，支持文档的生成、文档编辑、数字签名、文档合并、文档拆分、文档转换至PDF、文档查询等功能。

本项目依据 《GB/T 33190-2016 电子文件存储与交换格式版式文档》标准来实现的版式文档ODF库，依据《GM/T 0031-2014 安全电子签章密码技术规范》标准来实现的数字签名，依据《GM/T 0099-2020 开放版式文档密码应用技术规范》标准来实现OFD密码相关功能。

## 感谢支持

| 名称 | LOGO |
| :----:| :----: |
| JetBrains | [![JetBrains](https://resources.jetbrains.com/storage/products/company/brand/logos/jb_beam.svg?_ga=2.18748729.1472960975.1710982503-1993260277.1703834590&_gl=1*1o75dn2*_ga*MTk5MzI2MDI3Ny4xNzAzODM0NTkw*_ga_9J976DJZ68*MTcxMDk4MjUwMi43LjEuMTcxMDk4NDUwOC4zOC4wLjA.)](https://jb.gg/OpenSourceSupport) |
| Visual Studio | [![Visual Studio](https://visualstudio.microsoft.com/wp-content/uploads/2021/10/Product-Icon.svg)](https://visualstudio.microsoft.com/) |

## XiaoFeng.Ofd

XiaoFeng.Ofd generator with [XiaoFeng.Ofd](https://github.com/zhuovi/XiaoFeng.Ofd).

## Install

.NET CLI

```
$ dotnet add package XiaoFeng.Ofd --version 1.0.0
```

Package Manager

```
PM> Install-Package XiaoFeng.Ofd -Version 1.0.0
```

PackageReference

```
<PackageReference Include="XiaoFeng.Ofd" Version="1.0.0" />
```

Paket CLI

```
> paket add XiaoFeng.Ofd --version 1.0.0
```

Script & Interactive

```
> #r "nuget: XiaoFeng.Ofd, 1.0.0"
```

Cake

```
// Install XiaoFeng.Ofd as a Cake Addin
#addin nuget:?package=XiaoFeng.Ofd&version=1.0.0

// Install XiaoFeng.Ofd as a Cake Tool
#tool nuget:?package=XiaoFeng.Ofd&version=1.0.0
```


# XiaoFeng 类库包含库
| 命名空间 | 所属类库 | 开源状态 | 说明 | 包含功能 |
| :----| :---- | :---- | :----: | :---- |
| XiaoFeng.Prototype | XiaoFeng.Core | :white_check_mark: | 扩展库 | ToCase 类型转换<br/>ToTimestamp,ToTimestamps 时间转时间戳<br/>GetBasePath 获取文件绝对路径,支持Linux,Windows<br/>GetFileName 获取文件名称<br/>GetMatch,GetMatches,GetMatchs,IsMatch,ReplacePatten,RemovePattern 正则表达式操作<br/> |
| XiaoFeng.Net | XiaoFeng.Net | :white_check_mark: | 网络库 | XiaoFeng网络库，封装了Socket客户端，服务端（Socket,WebSocket），根据当前库可轻松实现订阅，发布等功能。|
| XiaoFeng.Http | XiaoFeng.Core | :white_check_mark: | 模拟请求库 | 模拟网络请求 |
| XiaoFeng.Data | XiaoFeng.Core | :white_check_mark: | 数据库操作库 | 支持SQLSERVER,MYSQL,ORACLE,达梦,SQLITE,ACCESS,OLEDB,ODBC等数十种数据库 |
| XiaoFeng.Cache | XiaoFeng.Core | :white_check_mark: | 缓存库 |  内存缓存,Redis,MemcachedCache,MemoryCache,FileCache缓存 |
| XiaoFeng.Config | XiaoFeng.Core | :white_check_mark: | 配置文件库 | 通过创建模型自动生成配置文件，可为xml,json,ini文件格式 |
| XiaoFeng.Cryptography | XiaoFeng.Core | :white_check_mark: | 加密算法库 | AES,DES,RSA,MD5,DES3,SHA,HMAC,RC4加密算法 |
| XiaoFeng.Excel | XiaoFeng.Excel | :white_check_mark: | Excel操作库 | Excel操作，创建excel,编辑excel,读取excel内容，边框，字体，样式等功能  |
| XiaoFeng.Ftp | XiaoFeng.Ftp | :white_check_mark: | FTP请求库 | FTP客户端 |
| XiaoFeng.IO | XiaoFeng.Core | :white_check_mark: | 文件操作库 | 文件读写操作 |
| XiaoFeng.Json | XiaoFeng.Core | :white_check_mark: | Json序列化，反序列化库 | Json序列化，反序列化库 |
| XiaoFeng.Xml | XiaoFeng.Core | :white_check_mark: | Xml序列化，反序列化库 | Xml序列化，反序列化库 |
| XiaoFeng.Log | XiaoFeng.Core | :white_check_mark: | 日志库 | 写日志文件,数据库 |
| XiaoFeng.Memcached | XiaoFeng.Memcached | :white_check_mark: | Memcached缓存库 | Memcached中间件,支持.NET框架、.NET内核和.NET标准库,一种非常方便操作的客户端工具。实现了Set,Add,Replace,PrePend,Append,Cas,Get,Gets,Gat,Gats,Delete,Touch,Stats,Stats Items,Stats Slabs,Stats Sizes,Flush_All,Increment,Decrement,线程池功能。|
| XiaoFeng.Redis | XiaoFeng.Redis | :white_check_mark: | Redis缓存库 | Redis中间件,支持.NET框架、.NET内核和.NET标准库,一种非常方便操作的客户端工具。实现了Hash,Key,String,ZSet,Stream,Log,List,订阅发布,线程池功能; |
| XiaoFeng.Threading | XiaoFeng.Core | :white_check_mark: | 线程库 | 线程任务,线程队列 |
| XiaoFeng.Mvc | XiaoFeng.Mvc | :x: | 低代码WEB开发框架 | .net core 基础类，快速开发CMS框架，真正的低代码平台，自带角色权限，WebAPI平台，后台管理，可托管到服务运行命令为:应用.exe install 服务名 服务说明,命令还有 delete 删除 start 启动  stop 停止。 |
| XiaoFeng.Proxy | XiaoFeng.Proxy | :white_check_mark: | 代理库 | 开发中 |
| XiaoFeng.TDengine | XiaoFeng.TDengine | :white_check_mark: | TDengine 客户端 | 开发中 |
| XiaoFeng.GB28181 | XiaoFeng.GB28181 | :white_check_mark: | 视频监控库，SIP类库，GB28181协议 | 开发中 |
| XiaoFeng.Onvif | XiaoFeng.Onvif | :white_check_mark: | 视频监控库Onvif协议 | XiaoFeng.Onvif 基于.NET平台使用C#封装Onvif常用接口、设备、媒体、云台等功能， 拒绝WCF服务引用动态代理生成wsdl类文件 ， 使用原生XML扩展标记语言封装参数，所有的数据流向都可控。 |
| FayElf.Plugins.WeChat | FayElf.Plugins.WeChat | :white_check_mark: | 微信公众号，小程序类库 | 微信公众号，小程序类库。 |
| XiaoFeng.Mqtt | XiaoFeng.Mqtt | :white_check_mark: | MQTT协议 | XiaoFeng.Mqtt中间件,支持.NET框架、.NET内核和.NET标准库,一种非常方便操作的客户端工具。实现了MQTT客户端，MQTT服务端,同时支持TCP，WebSocket连接。支持协议版本3.0.0,3.1.0,5.0.0。 |
| XiaoFeng.Modbus | XiaoFeng.Modbus | :white_check_mark: | MODBUS协议 | MODBUS协议,支持RTU、ASCII、TCP三种方式进行通信，自动离线保存服务端数据 |
| XiaoFeng.DouYin | XiaoFeng.DouYin | :white_check_mark: | 抖音开放平台SDK | 抖音开放平台接口 |
| XiaoFeng.KuaiShou | XiaoFeng.KuaiShou | :white_check_mark: | 快手开放平台SDK | 快手开放平台接口 |
| XiaoFeng.Mvc.AdminWinDesk | XiaoFeng.Mvc.AdminWinDesk | :white_check_mark: | XiaoFeng.Mvc后台皮肤 | 模仿windows桌面后台皮肤 |
| FayElf.Cube.Blog | FayElf.Cube.Blog | :white_check_mark: | XiaoFeng.Mvc开发的技术博客 | 使用低代码开发框架（XiaoFeng.Mvc）+Windows后台皮肤(XiaoFeng.Mvc.AdminWinDesk)，开发的一个博客平台。 |
| XiaoFeng.Ofd | XiaoFeng.Ofd | :white_check_mark: | OFD读写库 | OFD 读写处理库，支持文档的生成、文档编辑、文档批注、数字签名、文档合并、文档拆分、文档转换至PDF、文档查询等功能。 |

## 用法实例

### 读取器

### 写入器

### 数字签章

### 合并文档

# 作者介绍

* 网址 : https://www.eelf.cn
* QQ : 7092734
* Email : jacky@eelf.cn

---
