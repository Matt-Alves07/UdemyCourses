FROM mcr.microsoft.com/dotnet/aspnet:6.0
LABEL version="1.0.1" description="Aplicacao ASP .Net Core MVC"
COPY bin/release/net6.0/publish/ /app
WORKDIR /app
EXPOSE 5000/tcp
ENTRYPOINT ["dotnet","SalesWebMVC.dll"]