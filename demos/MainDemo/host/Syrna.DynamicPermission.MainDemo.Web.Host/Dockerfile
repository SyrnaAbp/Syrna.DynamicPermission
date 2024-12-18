#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["host/Syrna.DynamicPermission.Web.Unified/Syrna.DynamicPermission.Web.Unified.csproj", "host/Syrna.DynamicPermission.Web.Unified/"]
COPY ["src/Syrna.DynamicPermission.Web/Syrna.DynamicPermission.Web.csproj", "src/Syrna.DynamicPermission.Web/"]
COPY ["src/Syrna.DynamicPermission.HttpApi/Syrna.DynamicPermission.HttpApi.csproj", "src/Syrna.DynamicPermission.HttpApi/"]
COPY ["src/Syrna.DynamicPermission.Application.Contracts/Syrna.DynamicPermission.Application.Contracts.csproj", "src/Syrna.DynamicPermission.Application.Contracts/"]
COPY ["src/Syrna.DynamicPermission.Domain.Shared/Syrna.DynamicPermission.Domain.Shared.csproj", "src/Syrna.DynamicPermission.Domain.Shared/"]
COPY ["src/Syrna.DynamicPermission.Application/Syrna.DynamicPermission.Application.csproj", "src/Syrna.DynamicPermission.Application/"]
COPY ["src/Syrna.DynamicPermission.Domain/Syrna.DynamicPermission.Domain.csproj", "src/Syrna.DynamicPermission.Domain/"]
COPY ["src/Syrna.DynamicPermission.EntityFrameworkCore/Syrna.DynamicPermission.EntityFrameworkCore.csproj", "src/Syrna.DynamicPermission.EntityFrameworkCore/"]
COPY ["host/Syrna.DynamicPermission.Host.Shared/Syrna.DynamicPermission.Host.Shared.csproj", "host/Syrna.DynamicPermission.Host.Shared/"]
COPY Directory.Build.props .
RUN dotnet restore "host/Syrna.DynamicPermission.Web.Unified/Syrna.DynamicPermission.Web.Unified.csproj"
COPY . .
WORKDIR "/src/host/Syrna.DynamicPermission.Web.Unified"
RUN dotnet build "Syrna.DynamicPermission.Web.Unified.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Syrna.DynamicPermission.Web.Unified.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Syrna.DynamicPermission.Web.Unified.dll"]