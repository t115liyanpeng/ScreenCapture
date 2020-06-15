### 定时屏幕捕获器
---
- 功能说明
	- 定时截取屏幕图片并上传到指定的ftp
	- 支持图片压缩
	- 支持定时重启软件
	- 支持多屏幕截图
	
---

### 软件截图
![cap.png](https://i.loli.net/2020/06/15/TGbeWZRwaBUrVHP.png)
### 配置文件

	<appSettings>
		<!--是否开启定时重启-->
    	<add key="autorestart" value="true"/>
		<!--定时重启时间 小时（24h）-->
    	<add key="hh" value="1"/>
		<!--定时重启时间 分钟-->
    	<add key="mm" value="30"/>
    	<!--压缩率1-100填写0的时候不压缩-->
    	<add key="zip" value="50"/>
  	</appSettings>

