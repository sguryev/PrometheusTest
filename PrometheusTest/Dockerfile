# Build build image
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY PrometheusTest.csproj .
RUN dotnet restore PrometheusTest.csproj

# Copy everything else and build
COPY . .
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/runtime:3.1 as runtime-env
WORKDIR /app
COPY --from=build-env /app/out .

ENTRYPOINT ["dotnet", "PrometheusTest.dll"]