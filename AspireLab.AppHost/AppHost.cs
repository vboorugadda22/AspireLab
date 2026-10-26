var builder = DistributedApplication.CreateBuilder(args);

var webApi = builder.AddProject<Projects.AspireLab_WebApi>("webapi-service"); // add this line

builder.Build().Run();