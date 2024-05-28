[[_TOC_]]

# Code Build Deploy Blogs Service

The Code Build Deploy Blogs Service.

The api is deployed as a container, into [AKS](https://azure.microsoft.com/en-gb/products/kubernetes-service/).

[![Build Status](https://markpollard.visualstudio.com/CodeBuildDeploy/_apis/build/status%2FCodeBuildDeploy.Blogs?branchName=main)](https://markpollard.visualstudio.com/CodeBuildDeploy/_build/latest?definitionId=6&branchName=main)

# Standard DotNet Build

## Building

```bash
dotnet build
```

## Publishing

```bash
dotnet publish ./CodeBuildDeploy.Blogs.Api/CodeBuildDeploy.Blogs.Api.csproj --framework net8.0 --self-contained:false --no-restore -o ./publish
```

## Running

```bash
 dotnet run ./CodeBuildDeploy.Blogs.Api/CodeBuildDeploy.Blogs.Api.csproj
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
ConnectionStrings__BlogConnection=Connection_String_To_Blogs_Db
ConnectionStrings__BlogMigrationConnection=Admin_Connection_String_For_Running_Migrations
```

## Building and Running

```powershell
docker compose up -d --build
```

# Db Migration

The services use entity framework migrations code first to manage their associated schemas. 
The services have a dedicated project for the migrations code which builds a container that can be run against the appropriate database.

## Creating Migrations

The following commands have been used to create the ef migrations and scripts have also been generated for manual running and inspection. 

From the root directory of the project:

### Add Inital Db Migration

```bash
dotnet ef migrations add InitialCreate --project .\src\CodeBuildDeploy.Blogs.DA.EF.Deploy
```

### Script the database

```bash
dotnet ef migrations script 0 InitialCreate --project .\src\CodeBuildDeploy.Blogs.DA.EF.Deploy -o .\src\CodeBuildDeploy.Blogs.DA.EF.Deploy\DbScripts\10-InitialCreate.sql
```

## Running the migrations container

Running the 'finalMigration' target of the docker container will execute the migrations aginst the database connection specified in the environment variable:

```bash
FEED_ACCESSTOKEN=Access_Token_To_AzureDevOps_Feeds
ConnectionStrings__BlogMigrationConnection=Admin_Connection_String_For_Running_Migrations
``` 