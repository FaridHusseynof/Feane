
//15.sherlerimizi yoxlayib errorlari gosteririk ve _signInManager.PasswordSignInAsync ile log in edirik,
//ugurludursa indexe yonlendiririk;(signInResult.IsLockedOut ve !signInResult.Succeed)
//16.Rollar ucun RoleManager<IdentityRole> dependency injection edirik;
//17.ve Registere yaradilan her bir useri Member olaraq teyin etmek ucun
//_userManager.AddToRoleAsync(newUser, "Member");

using Feane.Data;
using Feane.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddIdentity<AppUser, IdentityRole>(options =>
{
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Lockout.MaxFailedAccessAttempts = 3;
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromSeconds(15);
}).AddDefaultTokenProviders().AddEntityFrameworkStores<FeaneDbContext>();
builder.Services.AddDbContext<FeaneDbContext>(options =>
{
    options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Feane;Trusted_Connection=True;TrustServerCertificate=True;");
});
var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();
app.UseStaticFiles();


app.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
          );
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );

app.Run();
