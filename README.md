# Tech stack
- ASP.NET Core 3.0 (with .NET Core 3.0)
- ASP.NET WebApi Core
- ASP.NET Identity Core
- Entity Framework Core 3.0
- .NET Core Native DI
- AutoMapper
- FluentValidator
- MediatR
- Swagger UI
- MSSQL

# Design Patterns
- Domain Driven Design
- Domain Events
- Domain Notification
- CQRS
- Event Sourcing
- Unit Of Work
- Repository & Generic Repository
- Inversion of Control / Dependency injection
- ORM
- Mediator

# References
- https://github.com/EduardoPires/EquinoxProject

# Command create project structure
```
mkdir AspNetCore-DDD
cd AspNetCore-DDD
dotnet new globaljson --sdk-version 3.0.100
dotnet new sln
mkdir src
cd src
mkdir Common
cd Common
dotnet new classlib -f netcoreapp3.0
cd ..
mkdir WebApi
cd WebApi
dotnet new webapi --no-https
```

- Open .sln file with Visual Studio
- Right click on Solution > Add > Existing Item > global.json
- Right click on Solution > Add > New Solution Folder > src
- Right click on `src` folder > Add > Existing Project > Common.csproj

```
dotnet new sln -n AspNetCore-DDD
dotnet new classlib -n Common --framework netcoreapp3.0
dotnet new console
dotnet new mstest
dotnet new web (Web/Empty)
dotnet new mvc (Web/MVC)
dotnet new webapp (Web/MVC/Razor Pages)
dotnet new webapi (Web/WebAPI)
dotnet new gitignore
dotnet new globaljson
dotnet new nugetconfig
dotnet new webconfig

-n|--name <OUTPUT_NAME>
The name for the created output. If no name is specified, the name of the current directory is used.

-o|--output <OUTPUT_DIRECTORY>
Location to place the generated output. The default is the current directory.
```

# Postman

- Get list Customer
```curl
curl -X GET \
  http://localhost:5000/Customer/customer-management
```

- Get one Customer
```curl
curl -X GET \
  http://localhost:5000/Customer/customer-management/{customerId}
```

- Create customer
```curl
curl -X POST \
  http://localhost:5000/Customer/customer-management \
  -H 'content-type: application/json' \
  -d '{
	"name": "Xinh Nguyen",
	"email": "ntxinh@gmail.com",
	"birthDate": "2000-01-01T23:28:56.782Z"
}'
```

- Update customer
```curl
curl -X PUT \
  http://localhost:5000/Customer/customer-management \
  -H 'content-type: application/json' \
  -d '{
	"id": "e7767b0b-93fe-462d-95bb-9aa492d6a177",
	"name": "Xinh Nguyen 2",
	"email": "ntxinh@gmail.com",
	"birthDate": "2000-01-01T23:28:56.782Z"
}'
```

- Delete customer
```curl
curl -X DELETE \
  http://localhost:5000/Customer/customer-management/{customerId}
```

- History
```curl
curl -X GET \
  http://localhost:5000/Customer/customer-management/history/{customerId}
```
