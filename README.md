# Entity Framework Core
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

## Cons
1. Generic/ Inefficient type to property association
   <br/>Ex: NVARCHAR(MAX) for a string
1. Uses exec sp_executesql sp for bulk insert, This means the account should have privileges to execute 
      * Elivated privileges
      * Injection attacks
1. Review what EF is doing/ autogenerated code for better effeciency
1. Not Easy to profile/debug the SQL queries
1. Functions if used within where clause cannot be run against the db
   <br/> the data is fetched, converted to a list and then queried in local.
1. Slower in Production (as the userbase increases)

## Pros
1. Faster development time but reviewing the EF increases the development time
1. SQL knowledge isn't essential but without sufficient knowledge, optimisation wouldn't be possible.
Well suited for smaller databases

## Best Practices
Ensure Models are annotated to specify the exact data type.
Failing to do so might result in db optimization issues.
<br/>
Ex: 
Model property|Default Db type
-----|-------------------
string|NVARCHAR(MAX)
<br/>
Don't call C# methods within the query
Don't use .Include() within the query
Review EF changes all the time

## Where to from here ?
Check out `Dapper` a micro-ORM
-  Faster in Production<br/>
-  As Fast as ADO.Net<br/>
-  Easy to work for SQL developers<br/>
-  More control
-  Designed for loose coupling
Well Dapper uses connection.execute for insert/update/delete
For which we can still stick to EF

Enjoy :+1: 