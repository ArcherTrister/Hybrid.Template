FROM microsoft/dotnet:3.1-aspnetcore-runtime AS base
MAINTAINER LeXun archertrister@outlook.com

WORKDIR /app
EXPOSE 80

COPY ./bin/Release/netcoreapp3.1/publish /app
ENTRYPOINT ["dotnet", "LeXun.Demo.Web.dll"]
