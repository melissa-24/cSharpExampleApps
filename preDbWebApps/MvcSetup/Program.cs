var builder = WebApplication.CreateBuilder(args);

// Insert this second
builder.Services.AddControllersWithViews();
var app = builder.Build();

// Insert these 4 lines 1st
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

// These are 3rd
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Edit this string as you want
// app.MapGet("/", () => "Welcome to my C# MVC Setup Application");

// Comment out the MapGet and add these line app will now break.  We are now set up to use controllers
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
