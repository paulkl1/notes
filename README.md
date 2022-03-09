# notes
Coding Challenge project

To start project you will need:
1. VS Code 
2. Docker Desktop
3. ASP.NET Core Runtime 6.0.3


To start the api please do the following steps:
1. Open project in VS Code
2. Open Terminal and execute command: docker-compose up -d
3. Trusting the self-signed certificate. Open Terminal and execute: dotnet dev-certs https --trust
4. Start the Project.

You can test it with Postman or just by using Swagger.
The endpoint is: "https://localhost:7077/swagger", "https://localhost:7077/notes"

I spend about 2 hours and there are still a lot of points for improvement, but the first version of api is working fine. 

Next step I would add Unit Tests, do some refactoring - for instance add authenctfication for MongoDB, add new fucntionality and refactor exsiting when requirements will be specified. Also I would create a frontend.
