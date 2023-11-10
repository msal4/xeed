using ExceedConsultancy;
using ExceedConsultancy.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using System.Globalization;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.AddJsonConsole();
builder.Services.AddMvc(option => {
    option.EnableEndpointRouting = false;
});

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContextPool<AppDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddIdentity<ApplicationUser, Role>()
    .AddUserStore<UserStore<ApplicationUser, Role, AppDbContext, Guid, UserClaim, UserRole, UserLogin, UserToken, RoleClaim>>()
    .AddRoleStore<RoleStore<Role, AppDbContext, Guid, UserRole, RoleClaim>>()
    .AddEntityFrameworkStores<AppDbContext>();

string SecretKey = builder.Configuration.GetSection("reCAPTCHA:SecretKey").Value;
string SiteKey = builder.Configuration.GetSection("reCAPTCHA:SiteKey").Value;
string ApiKey = builder.Configuration.GetValue<string>("ApiKey");
string ApiKeyPass = builder.Configuration.GetValue<string>("ApiKeyPass");

// Add Localataion.
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

builder.Services.AddControllers()
        .AddViewLocalization(options => options.ResourcesPath = "Resources")
        .AddDataAnnotationsLocalization(option =>
        {
            var type = typeof(SharedResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            var factory = builder.Services.BuildServiceProvider().GetService<IStringLocalizerFactory>();
            var localizer = factory.Create("SharedResource", assemblyName.Name);
            option.DataAnnotationLocalizerProvider = (t, f) => localizer;
        });


Action<CookieAuthenticationOptions> cookieOptions = options =>
{
    options.LoginPath = "/Login";
    options.AccessDeniedPath = "/Denied";
    options.LoginPath = "/";

    options.SlidingExpiration = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(15);
};

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(cookieOptions);
builder.Services.AddAuthorization(optins => {



});

var supportedCultures = new[]
{
    new CultureInfo("en-US"),
    new CultureInfo("ar")
};

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseHttpsRedirection();
app.UseStatusCodePagesWithReExecute("/Error/{0}");

app.UseRequestLocalization(new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture("en-US"),
    SupportedCultures = supportedCultures,
    SupportedUICultures = supportedCultures
});

app.UseFileServer();
app.UseMvc(routes =>
{
    routes.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}");
});



app.Run();

