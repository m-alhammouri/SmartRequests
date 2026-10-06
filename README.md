# SmartRequests

ASP.NET Core Razor Pages application using C# (.NET 10) and SQLite through Entity Framework Core.

## Run locally

```powershell
dotnet restore
dotnet run
```

Open the localhost URL printed by the application. The SQLite database `SmartRequests.db` is created automatically on first startup and is excluded from Git.

## Verify

```powershell
dotnet build
```

The initial project includes a request model and database context. Request management pages will be added in subsequent development.

The initial schema uses `EnsureCreated`. Before evolving an existing database, switch to EF Core migrations; `EnsureCreated` does not update existing schemas.
