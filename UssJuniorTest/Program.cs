using UssJuniorTest;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.RegisterAppServices();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseRouting();

app.Run();