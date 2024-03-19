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
RUN curl -L https://raw.githubusercontent.com/Microsoft/artifacts-credprovider/master/helpers/installcredprovider.sh  | sh
ARG CBD_FEED_ACCESSTOKEN
ENV VSS_NUGET_EXTERNAL_FEED_ENDPOINTS="{\"endpointCredentials\": [{\"endpoint\":\"https://markpollard.pkgs.visualstudio.com/CodeBuildDeploy/_packaging/CodeBuildDeploy/nuget/v3/index.json\", \"username\":\"docker\", \"password\":\"${CBD_FEED_ACCESSTOKEN}\"}]}"
ARG BUILD_CONFIGURATION=Release
ARG VERSION=0.0.0-local
ARG ASSEMBLY_VERSION=0.0.0.0
ARG FILE_VERSION=0.0.0.0
ARG INFORMATIONAL_VERSION=0.0.0-local
ARG PACKAGE_VERSION=0.0.0-local
WORKDIR /src
COPY ["CodeBuildDeploy.Blogs/CodeBuildDeploy.Blogs.csproj", "CodeBuildDeploy.Blogs/"]
COPY ["CodeBuildDeploy.Blogs.Contract/CodeBuildDeploy.Blogs.Contract.csproj", "CodeBuildDeploy.Blogs.Contract/"]
COPY ["CodeBuildDeploy.Blogs.DataAccess/CodeBuildDeploy.Blogs.DataAccess.csproj", "CodeBuildDeploy.Blogs.DataAccess/"]
COPY ["./nuget.config", "./"]
RUN dotnet restore "./CodeBuildDeploy.Blogs/CodeBuildDeploy.Blogs.csproj"
COPY . .
WORKDIR "/src/CodeBuildDeploy.Blogs"
RUN dotnet build "./CodeBuildDeploy.Blogs.csproj" -p:Version=${VERSION} -p:AssemblyVersion=${ASSEMBLY_VERSION} -p:FileVersion=${FILE_VERSION} -p:InformationalVersion=${INFORMATIONAL_VERSION} -p:PackageVersion=${PACKAGE_VERSION} -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./CodeBuildDeploy.Blogs.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CodeBuildDeploy.Blogs.dll"]