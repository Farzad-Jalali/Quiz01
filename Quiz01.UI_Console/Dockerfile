#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/runtime:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Quiz01.UI_Console/Quiz01.UI_Console.csproj", "Quiz01.UI_Console/"]
COPY ["Quiz01.Services/Quiz01.Services.csproj", "Quiz01.Services/"]
RUN dotnet restore "Quiz01.UI_Console/Quiz01.UI_Console.csproj"
COPY . .
WORKDIR "/src/Quiz01.UI_Console"
RUN dotnet build "Quiz01.UI_Console.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Quiz01.UI_Console.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Quiz01.UI_Console.dll"]