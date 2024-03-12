FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS base
# Turn off Invariant mode and install icu packages for EntityFramework. 
# See: https://github.com/dotnet/SqlClient/issues/220
RUN apk add --no-cache icu-libs
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build
# Turn off Invariant mode and install icu packages for EntityFramework. 
# See: https://github.com/dotnet/SqlClient/issues/220
RUN apk add --no-cache icu-libs
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["CodeBuildDeploy.Blogs/CodeBuildDeploy.Blogs.csproj", "CodeBuildDeploy.Blogs/"]
COPY ["CodeBuildDeploy.Blogs.Contract/CodeBuildDeploy.Blogs.Contract.csproj", "CodeBuildDeploy.Blogs.Contract/"]
COPY ["CodeBuildDeploy.Blogs.DataAccess/CodeBuildDeploy.Blogs.DataAccess.csproj", "CodeBuildDeploy.Blogs.DataAccess/"]
COPY ["./nuget.config", "./"]
RUN dotnet restore "./CodeBuildDeploy.Blogs/CodeBuildDeploy.Blogs.csproj"
COPY . .
WORKDIR "/src/CodeBuildDeploy.Blogs"
RUN dotnet build "./CodeBuildDeploy.Blogs.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./CodeBuildDeploy.Blogs.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CodeBuildDeploy.Blogs.dll"]