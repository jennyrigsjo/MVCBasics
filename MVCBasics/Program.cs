
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();


// enforce use of periods as decimal separator
var cultureInfo = new CultureInfo("en-US"); 
CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;


app.MapControllerRoute(
    name: "default",
    pattern: "",
    defaults: new { controller = "Home", action = "About" }
    );

app.MapControllerRoute(
    name: "about",
    pattern: "about",
    defaults: new { controller = "Home", action = "About" }
    );

app.MapControllerRoute(
    name: "contact",
    pattern: "contact",
    defaults: new { controller = "Home", action = "Contact" }
    );

app.MapControllerRoute(
    name: "projects",
    pattern: "projects",
    defaults: new { controller = "Home", action = "Projects" }
    );

app.MapControllerRoute(
    name: "fevercheck",
    pattern: "fevercheck",
    defaults: new { controller = "Doctor", action = "FeverCheck" }
    );

app.Run();
