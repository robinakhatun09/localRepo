using CascadingProject.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddDbContext<CascadingContext>(options =>
//options.UseNpgsql(builder.Configuration.GetConnectionString("CascadingData")));

builder.Services.AddDbContext<CascadingContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("CascadingData");

    if (connectionString != null)
    {
        options.UseNpgsql(connectionString);
    }

});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
    app.UseStaticFiles();

    app.UseRouting();

    app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=CascadingData}/{action=Index}/{id?}");


app.Run();
