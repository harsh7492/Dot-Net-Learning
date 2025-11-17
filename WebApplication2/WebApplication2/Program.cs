using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Register DbContext with SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

// Needed for serving CSS, JS, images
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Static assets mapping (.NET 8 style)
app.MapStaticAssets();

// Default route now points to Harsh/page1
app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Harsh}/{action=page1}/{id?}")
    .WithStaticAssets();

app.Run();
