FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

COPY Product-api-v2/*.csproj ./
RUN dotnet restore

COPY Product-api-v2 ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/out .
EXPOSE 8081

ENTRYPOINT ["dotnet", "Product-api-v2.dll"]