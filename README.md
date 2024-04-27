[[_TOC_]]

# Code Build Deploy Blog Service

The Code Build Deploy Blog Service.

The site is deployed to [Azure Container Apps](https://azure.microsoft.com/en-gb/products/container-apps).

[![Build Status](https://markpollard.visualstudio.com/CodeBuildDeploy/_apis/build/status%2FCodeBuildDeploy.Blogs?branchName=main)](https://markpollard.visualstudio.com/CodeBuildDeploy/_build/latest?definitionId=6&branchName=main)

# Standard DotNet Build

## Building

```bash
dotnet build
```

## Publishing

```bash
dotnet publish ./CodeBuildDeploy.Blogs/CodeBuildDeploy.Blogs.csproj --framework net8.0 --self-contained:false --no-restore -o ./publish/net8.0
```

## Running

```bash
 dotnet run ./CodeBuildDeploy.Blogs/CodeBuildDeploy.Blogs.csproj
```

# Docker Build

## Generate Devcert

```powershell
dotnet dev-certs https -ep "$env:USERPROFILE\.aspnet\https\code-build-deploy.pfx" -p SOME_PASSWORD
dotnet dev-certs https --trust
```

## Configure the environment variable
Create a .env file based on the .env.example
```bash
FEED_ACCESSTOKEN=Access_Token_To_AzureDevOps_Feeds
CERT_PASSWORD=SOME_PASSWORD
ASPNETCORE_ENVIRONMENT=Development
ConnectionStrings__BlogsConnection=Connection_String_To_Blogs_Db
```

## Building and Running

```powershell
docker compose up -d --build
```