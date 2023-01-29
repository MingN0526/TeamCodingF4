using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TeamCodingF4.Data;
using TeamCodingF4.Models;

var builder = WebApplication.CreateBuilder(args);

var TeamCodingProjectconnectionString = builder.Configuration.GetConnectionString("Remote");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(TeamCodingProjectconnectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<MemberModel>(options =>
{
    options.SignIn.RequireConfirmedAccount = true;
}).AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddControllersWithViews();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(opt =>  //���w��cookie���覡���n�J
    {
        opt.AccessDeniedPath = "/system/accessdenied";   //AccessDeniedPath�O�w�n�J���S�v��
        opt.LoginPath = "/account/login"; //�S�n�J���ܷ|�۰ʾɨ즹�����n�D�n�J
        opt.ExpireTimeSpan = TimeSpan.FromSeconds(300);
        opt.Cookie.Name = "loginSuccess";
        opt.Cookie.HttpOnly = true; //�]�w��true����JavaScript���|Ū��
    }
    );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
