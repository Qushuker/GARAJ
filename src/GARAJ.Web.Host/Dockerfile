FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/GARAJ.Web.Host/GARAJ.Web.Host.csproj", "src/GARAJ.Web.Host/"]
COPY ["src/GARAJ.Web.Core/GARAJ.Web.Core.csproj", "src/GARAJ.Web.Core/"]
COPY ["src/GARAJ.Application/GARAJ.Application.csproj", "src/GARAJ.Application/"]
COPY ["src/GARAJ.Core/GARAJ.Core.csproj", "src/GARAJ.Core/"]
COPY ["src/GARAJ.EntityFrameworkCore/GARAJ.EntityFrameworkCore.csproj", "src/GARAJ.EntityFrameworkCore/"]
WORKDIR "/src/src/GARAJ.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/GARAJ.Web.Host", "src/GARAJ.Web.Host"]
COPY ["src/GARAJ.Web.Core", "src/GARAJ.Web.Core"]
COPY ["src/GARAJ.Application", "src/GARAJ.Application"]
COPY ["src/GARAJ.Core", "src/GARAJ.Core"]
COPY ["src/GARAJ.EntityFrameworkCore", "src/GARAJ.EntityFrameworkCore"]
WORKDIR "/src/src/GARAJ.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "GARAJ.Web.Host.dll"]
