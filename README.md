# SqlServer User Defined Functions (UDF) Project

This project contains a set of user-defined functions (UDFs) for SQL Server, implemented in C#. The UDFs are designed to perform basic arithmetic operations and can be easily deployed to a SQL Server instance.

## Project Structure

```
SqlServerUdfProject
├── src
│   ├── UdfFunctions.cs        # Contains the UDF implementations
│   └── Properties
│       └── AssemblyInfo.cs    # Contains assembly metadata
├── SqlServerUdfProject.csproj  # Project configuration file
├── README.md                  # Project documentation
└── .gitignore                 # Git ignore file
```

## UDF Functions

The project includes the following user-defined functions:

- **AddNumbers**: Takes two integers as input and returns their sum.
- **GetCurrentDate**: Returns the current date.
- **MultiplyNumbers**: Takes two integers as input and returns their product.

## Building the Project

To build the project, you can use the .NET CLI. Navigate to the project directory and run the following command:

```
dotnet build
```

## Deploying to SQL Server

After building the project, you can deploy the UDFs to your SQL Server instance. Follow these steps:

1. Ensure that you have the necessary permissions to create UDFs in your SQL Server database.
2. Use the generated assembly to create the UDFs in SQL Server. You can use the following SQL command as an example:

```sql
CREATE ASSEMBLY [YourAssemblyName]
FROM 'path\to\your\assembly.dll'
WITH PERMISSION_SET = SAFE;

CREATE FUNCTION dbo.AddNumbers(@a INT, @b INT)
RETURNS INT
AS EXTERNAL NAME [YourAssemblyName].[Namespace.UdfFunctions].[AddNumbers];
```

Replace `YourAssemblyName` and `Namespace` with the appropriate values.

## License

This project is licensed under the MIT License. See the LICENSE file for more details.