using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddDapr(builder =>
    {
        builder.UseJsonSerializationOptions(new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            PropertyNameCaseInsensitive = true
        });
    });

builder.Services.AddDaprSidekick();

var app = builder.Build();

// Configure the HTTP request pipeline.

//app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();
//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapPost("reserve")
//})
app.MapSubscribeHandler();
app.MapControllers();

app.Run();