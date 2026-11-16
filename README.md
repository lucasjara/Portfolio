# Portfolio

Proyecto de portafolio profesional con ASP.NET Core Web API en .NET 10.

## Requisitos

- .NET SDK 10.0

## Estructura

- `Portfolio/`: API principal
- `Portfolio.Tests/`: pruebas automatizadas con xUnit
- `.github/workflows/`: integración continua con GitHub Actions

## Ejecutar localmente

```bash
dotnet restore Portfolio.slnx
dotnet build Portfolio.slnx --configuration Release --no-restore
dotnet run --project Portfolio/Portfolio.csproj
```

## Pruebas

```bash
dotnet test Portfolio.slnx --configuration Release
```

## Endpoints

- `GET /openapi/v1.json` (solo en entorno `Development`)

## CI

El workflow de CI se ejecuta en `push` y `pull_request` hacia `main` y realiza restauración, compilación en `Release` y ejecución de pruebas.
