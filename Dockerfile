FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
COPY ./ /src
WORKDIR /src
RUN dotnet publish -r linux-musl-x64 -p:PublishSingleFile=true \
    --self-contained true -c Release -o /deploy

#FROM scratch AS runtime
FROM mcr.microsoft.com/dotnet/runtime-deps:5.0-alpine-amd64 AS runtime
COPY --from=build /deploy/scratch /scratch
CMD ["./scratch"]
