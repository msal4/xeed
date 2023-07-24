

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json.Linq;


var builder = WebApplication.CreateBuilder(args);
builder.Logging.AddJsonConsole();
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);
builder.Services.AddDistributedMemoryCache();


//string recaptchaPrivateKey = builder.Configuration.GetValue<string>("recaptchaPrivateKey");
//string recaptchaPublickey = builder.Configuration.GetValue<string>("recaptchaPrivateKey");
string SecretKey = builder.Configuration.GetSection("reCAPTCHA:SecretKey").Value;
string SiteKey = builder.Configuration.GetSection("reCAPTCHA:SiteKey").Value;
string ApiKey = builder.Configuration.GetValue<string>("ApiKey");
string ApiKeyPass = builder.Configuration.GetValue<string>("ApiKeyPass");




builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
//builder.Services.AddDistributedMemoryCache();
//builder.Services.AddSession();


var app = builder.Build();

// app.Logger.LogInformation("Building App");

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

//app.UseHttpsRedirection();
//DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
//app.UseDefaultFiles(defaultFilesOptions);
//app.UseStaticFiles();


//app.UseSession();
//app.UseMvcWithDefaultRoute();
//app.UseMvc(routes =>
//{
//    routes.MapRoute(
//     name: "CPanel",
//     template: "{area:exists}/{controller=CPHome}/{action=Index}/{id?}");
//    routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");

//});

//app.MapGet("/", () => "Hello World!");


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

