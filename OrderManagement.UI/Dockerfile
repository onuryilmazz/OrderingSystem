FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /App

# Copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /App
COPY --from=build-env /App/out .

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=build-env /App/out/wwwroot .
COPY nginx.conf /etc/nginx/nginx.conf