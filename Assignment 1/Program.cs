using Assignment_1.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRouting(options =>
    {
        options.AppendTrailingSlash = true;
        options.LowercaseUrls = true;
    }
);
builder.Services.AddDbContext<ItemContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ItemContext")));

var app = builder.Build();




app.UseStaticFiles();

app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
