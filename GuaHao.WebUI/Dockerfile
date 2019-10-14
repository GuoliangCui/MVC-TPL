#基于镜像
FROM microsoft/dotnet:2.2-aspnetcore-runtime
#用户
MAINTAINER cuiguoliang 63354361@qq.com


COPY ./bin/Debug/netcoreapp2.1/publish /home/www
WORKDIR /home/www

#端口
EXPOSE 9000

CMD ["dotnet","GuaHao.WebUI.dll"]



# docker build -t ghweb:1.0 .
# docker run -d -p 8686:9000 ghweb:1.0