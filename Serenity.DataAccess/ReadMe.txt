This file contains developer notes

== Configure EF for Rider == 

1. Install following packages:
     - Microsoft.EntityFrameworkCore – the Entity Framework Core framework
     - Microsoft.EntityFrameworkCore.SqlServer – the SQL Server database driver (other databases are supported as well)
     - Microsoft.EntityFrameworkCore.Design – the Entity Framework Core design tooling
     - Microsoft.EntityFrameworkCore.SqlServer.Design – SQL Server-specific tooling
     - Microsoft.EntityFrameworkCore.Tools.DotNet – command line tools
2. Be sure that your project file (.csproj) contains properly references. See example:
    <Project Sdk="Microsoft.NET.Sdk.Web">
      <PropertyGroup>
        <TargetFramework>netcoreapp1.1</TargetFramework>
      </PropertyGroup>
      <ItemGroup>
        <PackageReference Include="Microsoft.AspNetCore" Version="1.1.2" />
        <PackageReference Include="Microsoft.AspNetCore.Mvc" Version="1.1.3" />
        <PackageReference Include="Microsoft.AspNetCore.StaticFiles" Version="1.1.2" />
    
        <PackageReference Include="Microsoft.EntityFrameworkCore" Version="1.1.0" />
        <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="1.1.0" />
    
        <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="1.1.0" />
        <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer.Design" Version="1.1.0" PrivateAssets="All" />
      </ItemGroup>
      <ItemGroup>
        <DotNetCliToolReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Tools" Version="1.0.1" />
        <DotNetCliToolReference Include="Microsoft.EntityFrameworkCore.Tools.DotNet" Version="1.0.0" />
      </ItemGroup>
    </Project>

== Usefull command to handle database using terminal (for Rider IDE) == 

- dotnet ef            - to test you're in the correct folder and can user Entity Framework
- dotnet restore       - if you see an error “No executable found matching command dotnet-ef” you should restore packages using this command
- dotnet ef dbcontext  - has set of commads to your datacontext (e.g. dbcontext scaffold)
- dotnet ef migrations - contains set of commands to handle migrations (e.g. migrations add)
- dotnet ef database   - contains set of commands to manage database (e.g. database update)

== Examples of EF commands for current solution == 
1. dotnet ef dbcontext scaffold "Server=(localdb)\MSSQLLocalDB;Integrated Security=true;" 
   Microsoft.EntityFrameworkCore.SqlServer -c ApplicationDbContext --startup-project ../Serenity.Web --force   
where:
   "Server=(localdb)\MSSQLLocalDB;Integrated Security=true;" - connection string
   ApplicationDbContext - the name of DataContext
   Microsoft.EntityFrameworkCore.SqlServer - default SQL provider
   ../Serenity.Web - startup project
   -- force - flag that allow to override existed data
   
2. dotnet ef migrations add Initial --startup-project ../Serenity.Web
where:
   Initial - the name of migration 

3. dotnet ef database update --startup-project ../Serenity.Web
