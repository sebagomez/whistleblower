FROM mcr.microsoft.com/dotnet/sdk:7.0 as builder

WORKDIR /src
COPY ./ /src

RUN dotnet publish --configuration Release -o ./bin ./whistleblower/whistleblower.csproj

FROM mcr.microsoft.com/dotnet/aspnet:7.0

LABEL maintainer="seba gomez <@sebagomez>"

WORKDIR /app

COPY --from=builder /src/bin ./

ENTRYPOINT ["dotnet", "whistleblower.dll"]
