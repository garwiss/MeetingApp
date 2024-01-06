
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //mvc yap�s�n� elle dahil ettik 
var app = builder.Build();

app.UseStaticFiles();  // wwwroot alt�ndaki dosyalar bu sayede a��k statik olarak

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


/*  -----> e�er wwwroot alt�nda ba�ka bir statik dosya eklemek ister isek a�a��daki kodu kullanmam�z gerekir dosya ad�n� da yaz�lmas� gerekir  npm ile yap�l�yorsa
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
           Path.Combine(builder.Environment.ContentRootPath, "MyStaticFiles")),
    RequestPath = "/StaticFiles"
});
*/