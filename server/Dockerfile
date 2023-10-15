FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

#coping csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

#copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

#build a runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /app
COPY  --from=build-env /app/out .
ENTRYPOINT [ "dotnet", "API.dll" ]