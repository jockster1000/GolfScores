FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app

# Copy the published web app
COPY /GolfScores.Web/ /app

# Run command
ENTRYPOINT ["dotnet", "GolfScores.Web.dll"]