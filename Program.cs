using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c=>
{
    c.SwaggerDoc("TimeV1", new Microsoft.OpenApi.Models.OpenApiInfo()
    {
        Title = "Time",
        Version = "V1"
    });

    c.SwaggerDoc("WeatherV3", new Microsoft.OpenApi.Models.OpenApiInfo()
    {
        Title = "Weather",
        Version = "V3"
    });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("swagger/TimeV1/swagger.json", "Time - V1");
    c.SwaggerEndpoint("swagger/WeatherV3/swagger.json", "Weather - V3");
    c.RoutePrefix = String.Empty;
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
