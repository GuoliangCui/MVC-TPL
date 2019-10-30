# MVC-TPL base T4+Dapper

## 基于T4模板的 MVC 模板程序
### 用PD或者其他工具生成sql脚本
### 生成数据库后 配置好数据库连接
#### 1. 打开Liang.T4/DBHelper.ttinclude文件
#### 2. 修改链接字符串  
####  private static string sqlConnStr = "server=10.1.11.126;port=3306;uid=manager;password=nidemima;character set=utf8mb4;";
### 分别保存Model,DAL,BLL种的T4模板会自动生成对应类

