using DrivingSchoolApp.Data;
using Microsoft.EntityFrameworkCore;
using DrivingSchoolApp.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(
        "server=localhost;database=DrivingSchoolDB;user=root;password=manager;",
        new MySqlServerVersion(new Version(8, 0, 21))
    ));

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Student}/{action=Index}/{id?}");

app.Run();