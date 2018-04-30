FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 82
ENV ASPNETCORE_URLS http://*:82

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY *.sln ./
COPY AKS-API/AKS-API.csproj AKS-API/
RUN dotnet restore
COPY . .
WORKDIR /src/AKS-API
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AKS-API.dll", "--server.urls", "http://*:82"]
#ENTRYPOINT ["dotnet", "run", "AKS-API.dll", "--server.urls", "http://*:49515"]