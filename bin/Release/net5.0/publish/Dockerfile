FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
ENV ASPNETCORE_URLS http://+:10957
# 暴露端口
EXPOSE 10957
WORKDIR /myapi
COPY . /myapi
ENTRYPOINT ["dotnet", "DB_docker_net5.dll"]