
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //mvc yapýsýný elle dahil ettik 
var app = builder.Build();

app.UseStaticFiles();  // wwwroot altýndaki dosyalar bu sayede açýk statik olarak

app.UseRouting();

//mvc
//rest api
//razor pages


//{controller=Home}/{action=Index}/?id
//app.MapDefaultControllerRoute();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();


/*  -----> eðer wwwroot altýnda baþka bir statik dosya eklemek ister isek aþaðýdaki kodu kullanmamýz gerekir dosya adýný da yazýlmasý gerekir  npm ile yapýlýyorsa
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
           Path.Combine(builder.Environment.ContentRootPath, "MyStaticFiles")),
    RequestPath = "/StaticFiles"
});
*/