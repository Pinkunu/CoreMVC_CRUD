FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["CoreMVC_CRUD/CoreMVC_CRUD.csproj", "CoreMVC_CRUD/"]
RUN dotnet restore "CoreMVC_CRUD/CoreMVC_CRUD.csproj"
COPY . .
WORKDIR "/src/CoreMVC_CRUD"
RUN dotnet build "CoreMVC_CRUD.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "CoreMVC_CRUD.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CoreMVC_CRUD.dll"]