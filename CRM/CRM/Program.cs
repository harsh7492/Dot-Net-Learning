using CRM.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// --- 1. CONFIGURE SERVICES ---

// Add controllers and views service
builder.Services.AddControllersWithViews();

// Database connection: Registers AppDbContext with SQL Server
// Ensure your appsettings.json has a "DefaultConnection" string
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Cookie Authentication setup (Custom Authentication)
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        // Redirect unauthorized users to the Login action
        options.LoginPath = "/Account/Login";
        // Configure the path for signing out
        options.LogoutPath = "/Account/Logout";
        // Set the time after which the cookie will expire (e.g., 30 minutes)
        options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
        // Reset the expiry timer on activity
        options.SlidingExpiration = true;

        // IMPORTANT: Configure access denied path if you implement authorization checks
        // options.AccessDeniedPath = "/Home/AccessDenied"; 
    });


// --- 2. BUILD APPLICATION AND CONFIGURE PIPELINE ---

var app = builder.Build();

// Error Handling
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios.
    app.UseHsts();
}

// Security and Static Files
app.UseHttpsRedirection(); // Recommended for production
app.UseStaticFiles();

// Routing must come before Authentication
app.UseRouting();

// Authentication + Authorization
// These MUST be placed between UseRouting() and MapControllerRoute()
app.UseAuthentication();
app.UseAuthorization();

// Default Route (Assuming Home/Welcome is the public entry point)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Welcome}/{id?}");

app.Run();