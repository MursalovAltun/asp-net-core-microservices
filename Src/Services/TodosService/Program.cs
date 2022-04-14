using Infrastructure.ServiceDiscovery;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterConsulServices(builder.Configuration.GetServiceConfig());

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();