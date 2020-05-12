FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/IdentityServer.UI/IdentityServer.UI.csproj", "src/IdentityServer.UI/"]
COPY ["src/IdentityServer.UI.Infrastructure.MySql/IdentityServer.UI.Infrastructure.MySql.csproj", "src/IdentityServer.UI.Infrastructure.MySql/"]
COPY ["src/IdentityServer.UI.Infrastructure.Identity/IdentityServer.UI.Infrastructure.Identity.csproj", "src/IdentityServer.UI.Infrastructure.Identity/"]
COPY ["src/IdentityServer.UI.Infrastructure/IdentityServer.UI.Infrastructure.csproj", "src/IdentityServer.UI.Infrastructure/"]
COPY ["src/IdentityServer.UI.Infrastructure.Extensions/IdentityServer.UI.Infrastructure.Extensions.csproj", "src/IdentityServer.UI.Infrastructure.Extensions/"]
COPY ["src/IdentityServer.UI.Infrastructure.Shared/IdentityServer.UI.Infrastructure.Shared.csproj", "src/IdentityServer.UI.Infrastructure.Shared/"]
COPY ["src/IdentityServer.UI.Infrastructure.PostgreSQL/IdentityServer.UI.Infrastructure.PostgreSQL.csproj", "src/IdentityServer.UI.Infrastructure.PostgreSQL/"]
COPY ["src/IdentityServer.UI.Infrastructure.SqlServer/IdentityServer.UI.Infrastructure.SqlServer.csproj", "src/IdentityServer.UI.Infrastructure.SqlServer/"]
RUN dotnet restore "src/IdentityServer.UI/IdentityServer.UI.csproj"
COPY . .
WORKDIR "/src/src/IdentityServer.UI"
RUN dotnet build "IdentityServer.UI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "IdentityServer.UI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_FORWARDEDHEADERS_ENABLED=true
ENTRYPOINT ["dotnet", "IdentityServer.UI.dll"]
