var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddDapr();

builder.Services.AddDaprClient();

builder.Services.AddDaprSidekick();

var app = builder.Build();

// Configure the HTTP request pipeline.

//app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();
app.MapSubscribeHandler();
app.MapControllers();

app.Run();
