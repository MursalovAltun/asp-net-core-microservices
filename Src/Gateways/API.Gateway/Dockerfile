FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Src/Gateways/API.Gateway/API.Gateway.csproj", "Src/Gateways/API.Gateway/"]
RUN dotnet restore "Src/Gateways/API.Gateway/API.Gateway.csproj"
COPY . .
WORKDIR "/src/Src/Gateways/API.Gateway"
RUN dotnet build "API.Gateway.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "API.Gateway.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "API.Gateway.dll"]
