# Etapa 1: Construcción (Build)
FROM mcr.microsoft.com/dotnet/sdk:9.0-alpine AS build
WORKDIR /src
COPY ["panditaAS.csproj", "./"]
RUN dotnet restore "panditaAS.csproj"
COPY . .
RUN dotnet build "panditaAS.csproj" -c Release -o /app/build

# Etapa 2: Publicación (Publish)
FROM build AS publish
RUN dotnet publish "panditaAS.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Etapa 3: Imagen Final (Runtime)
FROM mcr.microsoft.com/dotnet/aspnet:9.0-alpine AS final
WORKDIR /app
EXPOSE 8080
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "panditaAS.dll"]