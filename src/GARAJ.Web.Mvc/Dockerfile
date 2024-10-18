FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

RUN dotnet tool install -g Microsoft.Web.LibraryManager.Cli
RUN ln -s ~/.dotnet/tools/libman /usr/local/bin/libman

WORKDIR /src
COPY ["src/GARAJ.Web.Mvc/GARAJ.Web.Mvc.csproj", "src/GARAJ.Web.Mvc/"]
COPY ["src/GARAJ.Web.Core/GARAJ.Web.Core.csproj", "src/GARAJ.Web.Core/"]
COPY ["src/GARAJ.Application/GARAJ.Application.csproj", "src/GARAJ.Application/"]
COPY ["src/GARAJ.Core/GARAJ.Core.csproj", "src/GARAJ.Core/"]
COPY ["src/GARAJ.EntityFrameworkCore/GARAJ.EntityFrameworkCore.csproj", "src/GARAJ.EntityFrameworkCore/"]
WORKDIR "/src/src/GARAJ.Web.Mvc"
RUN dotnet restore 

WORKDIR /src
COPY ["src/GARAJ.Web.Mvc", "src/GARAJ.Web.Mvc"]
COPY ["src/GARAJ.Web.Core", "src/GARAJ.Web.Core"]
COPY ["src/GARAJ.Application", "src/GARAJ.Application"]
COPY ["src/GARAJ.Core", "src/GARAJ.Core"]
COPY ["src/GARAJ.EntityFrameworkCore", "src/GARAJ.EntityFrameworkCore"]
WORKDIR "/src/src/GARAJ.Web.Mvc"
RUN libman restore
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "GARAJ.Web.Mvc.dll"]
