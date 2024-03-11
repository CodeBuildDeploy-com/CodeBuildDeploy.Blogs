
FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS base
# Turn off Invariant mode and install icu packages for EntityFramework. 
# See: https://github.com/dotnet/SqlClient/issues/220
RUN apk add --no-cache icu-libs
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false
WORKDIR /app
EXPOSE 8080
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build
# Turn off Invariant mode and install icu packages for EntityFramework. 
# See: https://github.com/dotnet/SqlClient/issues/220
RUN apk add --no-cache icu-libs
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false
WORKDIR /
COPY ["CodeBuildDeploy.Blogs/CodeBuildDeploy.Blogs.csproj", "CodeBuildDeploy.Blogs/"]
RUN dotnet restore "CodeBuildDeploy.Blogs/CodeBuildDeploy.Blogs.csproj"
COPY . .
WORKDIR "/CodeBuildDeploy.Blogs"
RUN dotnet build "CodeBuildDeploy.Blogs.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CodeBuildDeploy.Blogs.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CodeBuildDeploy.Blogs.dll"]