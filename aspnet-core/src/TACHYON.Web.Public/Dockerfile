#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/TACHYON.Web.Public/TACHYON.Web.Public.csproj", "src/TACHYON.Web.Public/"]
COPY ["src/TACHYON.Web.Core/TACHYON.Web.Core.csproj", "src/TACHYON.Web.Core/"]
COPY ["src/TACHYON.Application/TACHYON.Application.csproj", "src/TACHYON.Application/"]
COPY ["src/TACHYON.Application.Shared/TACHYON.Application.Shared.csproj", "src/TACHYON.Application.Shared/"]
COPY ["src/TACHYON.Core.Shared/TACHYON.Core.Shared.csproj", "src/TACHYON.Core.Shared/"]
COPY ["src/TACHYON.Core/TACHYON.Core.csproj", "src/TACHYON.Core/"]
COPY ["src/TACHYON.EntityFrameworkCore/TACHYON.EntityFrameworkCore.csproj", "src/TACHYON.EntityFrameworkCore/"]
COPY ["src/TACHYON.GraphQL/TACHYON.GraphQL.csproj", "src/TACHYON.GraphQL/"]
RUN dotnet restore "src/TACHYON.Web.Public/TACHYON.Web.Public.csproj"
COPY . .
WORKDIR "/src/src/TACHYON.Web.Public"
RUN dotnet build "TACHYON.Web.Public.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TACHYON.Web.Public.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TACHYON.Web.Public.dll"]
