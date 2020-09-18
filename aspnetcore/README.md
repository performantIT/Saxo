# IO.Swagger - ASP.NET Core 2.0 Server

The TicTacToe API is a basic suite of tools bringing TicTacToe gaming functionality to your webpages and apps. In its current version, the TicTacToe API only supports two player matchmaking scenarios - (1) where opponent for your user is assigned authomatically and (2) where your user choses a single player to challenge.

## Run

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```

## Run in Docker

```
cd src/IO.Swagger
docker build -t io.swagger .
docker run -p 5000:5000 io.swagger
```
