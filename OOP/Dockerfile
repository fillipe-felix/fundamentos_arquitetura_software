FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["OOP/OOP.csproj", "OOP/"]
RUN dotnet restore "OOP/OOP.csproj"
COPY . .
WORKDIR "/src/OOP"
RUN dotnet build "OOP.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OOP.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OOP.dll"]
