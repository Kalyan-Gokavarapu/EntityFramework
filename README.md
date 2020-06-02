# EntityFramework
Sample API app to learn Entity framework

## Steps to work with entity framework
1. Identify and create models
1. Create a DataContext class, specify the `DbSet<T>`
1. Configure EntityFramework
    * Add connection string in `appsettings.json`
    * `services.AddDbContext<T>`(options =>... provide the connection string);
1. Install the required nuget packages
    * Microsoft.EntityFrameworkCore.SqlServer
    * Microsoft.EntityFrameworkCore.Tools (Tools for nuget package mgr console in Visual Studio)
    <br/>This allows us to add migration
1. Add migration scripts using Package Manager console
    * `Add-Migration InitialDBCreation`
1. Create/Update the database using Package Manager console
    * `Update-Database`
1. Annotate the properties in the models
    * `[Required]`
    * `[MaxLength(20)]`
    * `[Column(TypeName ="varchar(10)")]`
1. Insert init data into the db using <dbContext>.AddRange(<T>), if required.

## Best Practices
Ensure Models are annotated to specify the exact data type.
Failing to do so might result in db optimization issues.
<br/>
Ex: 
Model property|Default Db type
-----|-------------------
string|NVARCHAR(MAX)
