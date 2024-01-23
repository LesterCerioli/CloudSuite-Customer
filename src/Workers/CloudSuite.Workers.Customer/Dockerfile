#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Workers/CloudSuite.Workers.Customer/CloudSuite.Workers.Customer.csproj", "src/Workers/CloudSuite.Workers.Customer/"]
RUN dotnet restore "./src/Workers/CloudSuite.Workers.Customer/./CloudSuite.Workers.Customer.csproj"
COPY . .
WORKDIR "/src/src/Workers/CloudSuite.Workers.Customer"
RUN dotnet build "./CloudSuite.Workers.Customer.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./CloudSuite.Workers.Customer.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CloudSuite.Workers.Customer.dll"]