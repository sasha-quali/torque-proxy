using Quali.Torque.Spec1Gateway.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddNewtonsoftJson();

var app = builder.Build();

app.MapControllers();
app.UseFaker();

app.Run();
