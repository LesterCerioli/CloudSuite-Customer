#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Rest/CloudSuite.Services.Customer.Api/CloudSuite.Services.Customer.Api.csproj", "src/Rest/CloudSuite.Services.Customer.Api/"]
RUN dotnet restore "./src/Rest/CloudSuite.Services.Customer.Api/CloudSuite.Services.Customer.Api.csproj"
COPY . .
WORKDIR "/src/src/Rest/CloudSuite.Services.Customer.Api"
RUN dotnet build "./CloudSuite.Services.Customer.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./CloudSuite.Services.Customer.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CloudSuite.Services.Customer.Api.dll"]