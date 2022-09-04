var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers()
    .AddDapr();

builder.Services.AddDaprSidekick();

var app = builder.Build();

app.UseRouting();

app.UseAuthorization();
app.MapSubscribeHandler();
app.MapControllers();

app.Run();
