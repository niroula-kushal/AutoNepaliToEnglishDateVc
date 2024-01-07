FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["AutoNepaliToEnglishDateVc/AutoNepaliToEnglishDateVc.csproj", "AutoNepaliToEnglishDateVc/"]
RUN dotnet restore "AutoNepaliToEnglishDateVc/AutoNepaliToEnglishDateVc.csproj"
COPY . .
WORKDIR "/src/AutoNepaliToEnglishDateVc"
RUN dotnet build "AutoNepaliToEnglishDateVc.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "AutoNepaliToEnglishDateVc.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AutoNepaliToEnglishDateVc.dll"]
