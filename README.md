## How to Run

Execute the following commands in the root project:

```
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet restore
dotnet ef migrations add initialCreate
dontet ef database update
```

After that will be created a database, execute ```dotnet run``` to start up the application. 
