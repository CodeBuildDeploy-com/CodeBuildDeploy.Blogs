[[_TOC_]]

# Code Build Deploy Blog Service

The Code Build Deploy Blog Service.

The site is deployed to [Azure App Services](https://azure.microsoft.com/en-gb/products/app-service).

[![Build Status](https://markpollard.visualstudio.com/CodeBuildDeploy/_apis/build/status%2FCodeBuildDeploy.Blogs?branchName=master)](https://markpollard.visualstudio.com/CodeBuildDeploy/_build/latest?definitionId=4&branchName=master)

# Standard DotNet Build

## Building

```bash
dotnet build
```

## Publishing

```bash
dotnet publish ./CodeBuildDeploy.Blogs/CodeBuildDeploy.Blogs.csproj -v n --framework net8.0 --self-contained:false --no-restore -o ./publish/net8.0
```

## Running

```bash
 dotnet run ./CodeBuildDeploy.Blogs/CodeBuildDeploy.Blogs.csproj
```

# Docker Build

## Building

```powershell
. .\build.ps1
```

## Publishing

```powershell
docker push codebuilddeploy.azurecr.io/code-build-deploy-blogs:latest
```

## Pulling

```powershell
docker pull codebuilddeploy.azurecr.io/code-build-deploy-blogs:latest
```

## Running

```powershell
. .\run.ps1
```