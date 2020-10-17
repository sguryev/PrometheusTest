# https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/docker/building-net-docker-images?view=aspnetcore-3.1

# Build build image
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY PrometheusTestWeb.csproj .
RUN dotnet restore PrometheusTestWeb.csproj

# Copy everything else and build
COPY . .
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 as runtime-env
WORKDIR /app
COPY --from=build-env /app/out .

ENTRYPOINT ["dotnet", "PrometheusTestWeb.dll"]