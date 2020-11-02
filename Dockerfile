#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["GadgetStoreMVC.Core/GadgetStoreMVC.Core.csproj", "GadgetStoreMVC.Core/"]
COPY ["GadgetStoreMVC.Models/GadgetStoreMVC.Models.csproj", "GadgetStoreMVC.Models/"]
COPY ["GadgetStoreMVC.Services/GadgetStoreMVC.Services.csproj", "GadgetStoreMVC.Services/"]
COPY ["GadgetStoreMVC.Repository/GadgetStoreMVC.Repository.csproj", "GadgetStoreMVC.Repository/"]
COPY ["GadgetStoreMVC.Data/GadgetStoreMVC.Data.csproj", "GadgetStoreMVC.Data/"]
COPY ["GadgetStoreMVC.Auxiliaries/GadgetStoreMVC.Auxiliaries.csproj", "GadgetStoreMVC.Auxiliaries/"]
RUN dotnet restore "GadgetStoreMVC.Core/GadgetStoreMVC.Core.csproj"
COPY . .
WORKDIR "/src/GadgetStoreMVC.Core"
RUN dotnet build "GadgetStoreMVC.Core.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GadgetStoreMVC.Core.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "GadgetStoreMVC.Core.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet GadgetStoreMVC.Core.dll