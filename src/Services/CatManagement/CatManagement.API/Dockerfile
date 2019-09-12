FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY src/Services/CatManagement/CatManagement.API/CatManagement.API.csproj src/Services/CatManagement/CatManagement.API/
RUN dotnet restore src/Services/CatManagement/CatManagement.API/CatManagement.API.csproj
COPY . .
WORKDIR /src/src/Services/CatManagement/CatManagement.API
RUN dotnet build CatManagement.API.csproj -c Release -o /app

FROM build as unittest
WORKDIR /src/src/Services/CatManagement/tests/CatManagement.UnitTests

FROM build AS publish
RUN dotnet publish CatManagement.API.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CatManagement.API.dll"]
