FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
WORKDIR /src
COPY ["Graficas.WEB/Graficas.WEB.csproj", "Graficas.WEB/"]
COPY ["Graficas.Models/Graficas.Models.csproj", "Graficas.Models/"]
COPY ["Graficas.BLL/Graficas.BLL.csproj", "Graficas.BLL/"]
COPY ["Graficas.DAL/Graficas.DAL.csproj", "Graficas.DAL/"]
RUN dotnet restore "Graficas.WEB/Graficas.WEB.csproj"
COPY . .
WORKDIR "/src/Graficas.WEB"
RUN dotnet build "Graficas.WEB.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Graficas.WEB.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Graficas.WEB.dll"]
