var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // Add MVC

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Hello}/{action=Index}/{id?}");

app.Run();
