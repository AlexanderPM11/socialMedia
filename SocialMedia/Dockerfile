# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443


# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["SocialMedia/WebApp.SocialMedia.csproj", "SocialMedia/"]
COPY ["SocialMedia.Core.Aplication/SocialMedia.Core.Aplication.csproj", "SocialMedia.Core.Aplication/"]
COPY ["SocialMedia.Core.Domain/SocialMedia.Core.Domain.csproj", "SocialMedia.Core.Domain/"]
COPY ["SocialMedia.Infrastructure.Persistence/SocialMedia.Infrastructure.Persistence.csproj", "SocialMedia.Infrastructure.Persistence/"]
COPY ["SocialMedia.Infrastructure.Shared/SocialMedia.Infrastructure.Shared.csproj", "SocialMedia.Infrastructure.Shared/"]
RUN dotnet restore "./SocialMedia/WebApp.SocialMedia.csproj"
COPY . .
WORKDIR "/src/SocialMedia"
RUN dotnet build "./WebApp.SocialMedia.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./WebApp.SocialMedia.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApp.SocialMedia.dll"]