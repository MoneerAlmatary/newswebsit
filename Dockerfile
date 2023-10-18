FROM mcr.microsoft.com/dotnet/sdk:7.0-alpine AS build-env

WORKDIR /NewsWebsit

COPY ["newswebsit.csproj", "."]

# # Restore as distinct layers
RUN dotnet restore "newswebsit.csproj"
COPY . .

# Build and publish a release
RUN dotnet build "newswebsit.csproj" -c Release -o out
RUN dotnet publish "newswebsit.csproj" -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0-alpine
WORKDIR /newswebsit
COPY --from=build-env /newswebsit/out .

EXPOSE 80

ENTRYPOINT ["dotnet", "newswebsit.dll"]