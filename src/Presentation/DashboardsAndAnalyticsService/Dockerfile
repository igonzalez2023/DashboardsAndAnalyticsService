FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["DashboardsAndAnalyticsService/DashboardsAndAnalyticsService.csproj", "DashboardsAndAnalyticsService/"]
RUN dotnet restore "DashboardsAndAnalyticsService/DashboardsAndAnalyticsService.csproj"
COPY . .
WORKDIR "/src/DashboardsAndAnalyticsService"
RUN dotnet build "DashboardsAndAnalyticsService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DashboardsAndAnalyticsService.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DashboardsAndAnalyticsService.dll"]
