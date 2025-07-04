using sellyourcar.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();



builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));




var app = builder.Build();

// Configure middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

// ✅ This serves static files (like CSS, JS, images from wwwroot)
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Configure routing for controllers
app.MapControllerRoute(

    name: "default",
    pattern: "{controller=Home}/{action=Privacy}/{id?}"

    );

app.Run();
