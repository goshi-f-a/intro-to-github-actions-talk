var builder = WebApplication.CreateBuilder(args);

// Add services (previously in Startup.ConfigureServices)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure pipeline (previously in Startup.Configure)
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
