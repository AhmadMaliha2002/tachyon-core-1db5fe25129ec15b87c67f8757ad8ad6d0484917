#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/TACHYON.Migrator/TACHYON.Migrator.csproj", "src/TACHYON.Migrator/"]
COPY ["src/TACHYON.EntityFrameworkCore/TACHYON.EntityFrameworkCore.csproj", "src/TACHYON.EntityFrameworkCore/"]
COPY ["src/TACHYON.Core/TACHYON.Core.csproj", "src/TACHYON.Core/"]
COPY ["src/TACHYON.Core.Shared/TACHYON.Core.Shared.csproj", "src/TACHYON.Core.Shared/"]
RUN dotnet restore "src/TACHYON.Migrator/TACHYON.Migrator.csproj"
COPY . .
WORKDIR "/src/src/TACHYON.Migrator"
RUN dotnet build "TACHYON.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TACHYON.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TACHYON.Migrator.dll"]
