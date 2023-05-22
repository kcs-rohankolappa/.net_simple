# Use the .NET SDK as the base image
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env

# Set the working directory inside the container
WORKDIR /app

# Copy the .NET project file(s) and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy the entire project directory and build the application
COPY . ./
RUN dotnet publish -c Release -o out

# Use a lightweight runtime image
FROM mcr.microsoft.com/dotnet/runtime:7.0
WORKDIR /app
COPY --from=build-env /app/out .

# Set the entry point for the container
ENTRYPOINT ["dotnet", "MyConsoleApp.dll"]
