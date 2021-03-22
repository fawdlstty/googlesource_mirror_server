# googlesource_mirror_server

**此项目正在开发中，暂时无法使用**

googlesource镜像服务器，用于编译谷歌源码项目

由于GFW的存在，使得国内开发者对googlesource项目的编译及开发造成很大的阻碍。比如编译chromium、编译skia、编译webrtc等等。此项目目标在完全符合GFW规则的前提下，尽量消除开发者使用googlesource的障碍，免翻墙。

原理：

1. 通过国内能直接访问的googlesource镜像克隆仓库
2. 本地服务器提供http(s)访问克隆仓库的方式
3. 修改hosts，将googlesource地址指向本地服务器
4. 然后自由的使用googlesource

（估计是以后的）使用方法：

1. 克隆镜像仓库，并在后台配置
2. git移除证书检测
	- `git config --global http.sslVerify false`
3. 修改客户机的host
	- 127.0.0.1 android.googlesource.com
	- 127.0.0.1 chromium.googlesource.com
	- ...
4. 遇到任何问题，欢迎在issue里提问
