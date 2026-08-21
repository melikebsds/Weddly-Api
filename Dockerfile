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
# appsettings.json değişikliklerini izlemek için açılan FileSystemWatcher'lar
# container'ın inotify limitini (varsayılan 128) tüketip "IOException: configured
# user limit on inotify instances" hatasıyla çökmeye sebep olabiliyor.
# Config zaten deploy'da sabit; hot-reload'a gerek yok.
ENV DOTNET_hostBuilder__reloadConfigOnChange=false

ENTRYPOINT ["dotnet", "WeddingPlanner.Api.dll"]
