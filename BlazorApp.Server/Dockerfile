# https://github.com/dotnet/dotnet-docker/blob/main/samples/aspnetapp/Dockerfile
# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
COPY BlazorApp.Server/*.csproj ./BlazorApp.Server/
COPY BlazorApp.Infratructure/*.csproj ./BlazorApp.Infratructure/
COPY BlazorApp.Core/*.csproj ./BlazorApp.Core/
COPY BlazorApp.Client/*.csproj ./BlazorApp.Client/
WORKDIR /source/BlazorApp.Server
RUN dotnet restore "BlazorApp.Server.csproj"

# copy everything else and build app
WORKDIR /source
COPY BlazorApp.Server/. ./BlazorApp.Server/
COPY BlazorApp.Client/. ./BlazorApp.Client/
COPY BlazorApp.Infratructure/. ./BlazorApp.Infratructure/
COPY BlazorApp.Core/. ./BlazorApp.Core/
WORKDIR /source/BlazorApp.Server
RUN dotnet publish "BlazorApp.Server.csproj" -c release -o /app

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app ./

EXPOSE 7203/tcp
ENV ASPNETCORE_URLS http://*:7203
ENTRYPOINT ["dotnet", "BlazorApp.Server.dll"]