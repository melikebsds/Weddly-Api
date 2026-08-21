FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY WeddingPlanner.Api.csproj .
RUN dotnet restore WeddingPlanner.Api.csproj

COPY . .
RUN dotnet publish WeddingPlanner.Api.csproj -c Release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app
COPY --from=build /app .

ENV ASPNETCORE_ENVIRONMENT=Production
ENTRYPOINT ["dotnet", "WeddingPlanner.Api.dll"]
