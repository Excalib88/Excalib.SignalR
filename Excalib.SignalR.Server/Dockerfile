FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Excalib.SignalR.Server/Excalib.SignalR.Server.csproj", "Excalib.SignalR.Server/"]
RUN dotnet restore "Excalib.SignalR.Server/Excalib.SignalR.Server.csproj"
COPY . .
WORKDIR "/src/Excalib.SignalR.Server"
RUN dotnet build "Excalib.SignalR.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Excalib.SignalR.Server.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Excalib.SignalR.Server.dll"]
