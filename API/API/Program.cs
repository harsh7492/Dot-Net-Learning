var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();   // REQUIRED
builder.Services.AddSwaggerGen();             // REQUIRED

var app = builder.Build();

// Configure pipeline
app.UseHttpsRedirection();
app.UseAuthorization();

// Enable Swagger for all environments
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    c.RoutePrefix = string.Empty;   // <-- Opens Swagger at https://localhost:7149/
});

app.MapControllers();
app.Run();
