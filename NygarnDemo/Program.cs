using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NygarnDemo.EFDbContext;
using NygarnDemo.MockData;
using NygarnDemo.Models;
using NygarnDemo.Services;
using NygarnDemo.Services.Interfaces;
using NygarnDemo.Services.ProductServices;
using NygarnDemo.Services.User;
using static NygarnDemo.EFDbContext.YarnDbContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<IPatternService, PatternService>();
builder.Services.AddSingleton<ICrochetHookService, CrochetHookService>();
builder.Services.AddSingleton<IYarnService, YarnService>();
builder.Services.AddSingleton<IKnittingNeedleService, KnittingNeedleService>();
builder.Services.AddSingleton<IToolService, ToolService>();
builder.Services.AddDbContext<YarnDbContext>();
builder.Services.AddDbContext<ToolDbContext>();
builder.Services.AddSingleton<DbService, DbService>();
builder.Services.AddSingleton<UserService, UserService>();

builder.Services.Configure<CookiePolicyOptions>(options => {
    // This lambda determines whether user consent for non-essential cookies is needed for a given request. options.CheckConsentNeeded = context => true; 
    options.MinimumSameSitePolicy = SameSiteMode.None;

});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(cookieOptions => {
    cookieOptions.LoginPath = "/Login/LogInPage";

});
builder.Services.AddMvc().AddRazorPagesOptions(options => {
    options.Conventions.AuthorizeFolder("/User");

}).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
