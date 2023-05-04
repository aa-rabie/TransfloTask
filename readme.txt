•	The application is built using .NET 7 and REST APIs are implemented using Minimal APIs. 
•	Application uses SQLite DB.
•	Unit and Integration tests are written using XUnit

Solution build prerequisites
•	Installing .NET 7 SDK on target machine.

Execution steps
1.	Open the solution in Visual Studio 2022.
2.	Assure that “Transflo.Driver.Api” is startup project. 
3.	Rebuild the solution and assure that nugets are restored successfully.
4.	Press CTRL + F5 to run the solution.
5.	New browser window will open at https://localhost:7291/swagger/index.html 
6.	This page is OpenAPI “Swagger” UI explorer screen and can  be used to test the exposed APIs. 
