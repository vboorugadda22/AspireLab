var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

// Add services to application here.

builder.AddServiceDefaults();

var app = builder.Build();

// Configure the HTTP request pipeline here.

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    // add things used during development, but should not be released to production
}
app.UseHttpsRedirection();

app.MapGet("/hello", () => "Hello, world!");

app.MapDefaultEndpoints();

app.Run();
