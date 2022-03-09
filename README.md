# Notes
Coding Challenge project

To start project you will need:
1. VS Code 
2. Docker Desktop
3. ASP.NET Core Runtime 6.0.3


To start the api please do the following steps:
1. Open project in VS Code
2. Open Terminal and execute command: **docker-compose up -d**
3. Trust the self-signed certificate. Open Terminal and execute:  **dotnet dev-certs https --trust**
4. Start the Project.

You can test it with Postman or just by using Swagger.
The endpoint is: "https://localhost:7077/swagger", "https://localhost:7077/notes"

There are also 2 health checks for the API implemeted:
1. https://localhost:7077/health/live - checks if the API available
2. https://localhost:7077/health/ready - checks if there any problem with database connection

I spend about 2 hours and there are still a lot of points for improvement, but the first version of api is working fine. 

Next step I would add Unit Tests, do some refactoring - for instance add authenctfication for MongoDB, add new fucntionality and refactor existing when requirements will be specified. Also I would create a frontend and take care about deployment. For the deployment I've already created a docker file, so we can deploy it.
