from mcr.microsoft.com/dotnet/sdk:8.0 AS build 


# Create a non-root user
# RUN useradd -ms /bin/bash myuser

# Set the non-root user
# USER myuser


WORKDIR /app
COPY *.csproj ./


ENV PATH="$PATH:/root/.dotnet/tools"

RUN dotnet tool install -g dotnet-ef 


run dotnet restore 
# Set PATH environment variable
COPY .  ./
run dotnet publish -c Release -o output

EXPOSE 5265

ENTRYPOINT [ "sh","./command.sh" ]