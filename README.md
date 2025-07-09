

# Engrama Core

A comprehensive library of functions and processes designed to simplify software development.
Access databases, integrate with APIs, generate documents, and handle JSON—everything required 
for day-to-day operations, conveniently available in a single NuGet package.

## Installations
To install Engrama Core, you can use the following steps in your API .NET:

- On the Program.cs class se the next line 
```csharp
using EngramaCoreStandar.Extensions;

builder.Services.AddEngramaDependenciesAPI();
```
## How to use it ?

- On your controller set the next parameter in the constructor:
```csharp
[ApiController]
[Route("api/[controller]")]
public class QuickRequestController : ControllerBase
{
	private readonly IDapperManagerHelper managerHelper;

	public QuickRequestController(IDapperManagerHelper managerHelper)
	{
		this.managerHelper = managerHelper;
	}
}
```

- In your appsettings.json file, add your connection string, or use the following one to test the code:
```json

    "ConnectionStrings": {
        "EngramaCloudConnection": "Data Source=Engrama.mssql.somee.com;Initial Catalog=Engrama;User ID=MMartinez_SQLLogin_1;Password=95xodkhgxa;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

    },
```

- On your endpoint set the next code to call the stored procedure in the database:
This is only and exmple you use your own procedure and your own atributes.

```csharp
[HttpPost("PostCallDB")]
public async Task<IActionResult> PostTestTable([FromBody] PostModelTestTable postModel)
{

   //The tool need one class to send at the procedure and other class the one will receive the data. (Request and resutl)
	var DAOmodel = new spGetTestTable.Request();
	var result = await managerHelper.GetAllAsync<spGetTestTable.Result, spGetTestTable.Request>(DAOmodel, "");


	if (result.Ok)
	{
		return Ok(result.Data);
	}
	return BadRequest(result);
}
public class PostModelTestTable
{

}

public class spGetTestTable
{
	public class Request : SpRequest
	{
		public string StoredProcedure { get => "spGetTestTable"; }
	}
	public class Result : DbResult
	{
		public bool bResult { get; set; }
		public string vchMessage { get; set; }
		public int iIdTest_Table { get; set; }
		public string vchName { get; set; }
		public string vchEmail { get; set; }
		public DateTime dtRegistered { get; set; }
	}
}
```
## Let’s get started

If you need a fully functional template, download it from our GitHub repository and start working right away.

- [Template: API and PWA with Engrama and MudBlazor Installed](https://github.com/IscMagdaleno/TemplatePWA)

To work with the template, follow this video: [Tutorial on How to Use the Template](https://youtu.be/9GnTMlMzhis?si=0pw0ULJpJYIZZOlM)

## Documentation

Discover how Engrama Core and Engrama Tools work by following our YouTube channel. 
Watch our tutorials to make the most of these powerful tools
[Canal de Youtube](https://www.youtube.com/playlist?list=PLYyjb1f9Qib9anw1lUKOkP9P6PmeZUQmW)
Use our documentation to implement the NuGet package and take full advantage of all the tools Engrama Core offers.
[Engrama Documentacion](https://engramadocumetation.azurewebsites.net/documentacion)



## Characteristics

- Perform database queries efficiently
- Integrate with APIs seamlessly
- Send emails with ease
- Read and create Excel files effortlessly
- Implement JWT authentication securely
- Utilize robust logging mechanisms
- Read and generate PDF documents
- Use variable extensions to streamline validations and simplify functions


## Engrama Tools

- [Engrama tools](https://engrama.azurewebsites.net)

A web application built to fully leverage the capabilities of EngramaCore. By analyzing the database,
it provides the essential code to facilitate database queries seamlessly from the service layer to the architecture layer, along with numerous additional tools and features.


## 🔗 Links


[![linkedin](https://img.shields.io/badge/linkedin-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/magdaleno-martínez-unzueta-582570177)



[![YouTube](https://img.shields.io/badge/YouTube-%23FF0000.svg?style=for-the-badge&logo=YouTube&logoColor=white)](https://www.youtube.com/@EngramaDev)




## 🛠 Skills 

-   C# 
-   SQL
-   .NET Core
-   Blazor (Opcional)
-   Visual Studio 2022



## Authors

- [@IscMagdaleno](https://github.com/IscMagdaleno)


## Comments

For any questions or feedback, don't hesitate to reach out to us at engramahelper@gmail.com.

