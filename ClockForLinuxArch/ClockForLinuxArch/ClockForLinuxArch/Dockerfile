FROM mcr.microsoft.com/dotnet/runtime:9.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["ClockForLinuxArch/ClockForLinuxArch.csproj", "ClockForLinuxArch/"]
RUN dotnet restore "ClockForLinuxArch/ClockForLinuxArch.csproj"
COPY . .
WORKDIR "/src/ClockForLinuxArch"
RUN dotnet build "./ClockForLinuxArch.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ClockForLinuxArch.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ClockForLinuxArch.dll"]
