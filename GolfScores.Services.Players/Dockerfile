#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["./GolfScores.Services.Players.csproj", ""]
RUN dotnet restore "./GolfScores.Services.Players.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "GolfScores.Services.Players.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GolfScores.Services.Players.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GolfScores.Services.Players.dll"]