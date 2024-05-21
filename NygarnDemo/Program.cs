using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NygarnDemo.EFDbContext;
using NygarnDemo.Services;
using NygarnDemo.Services.DbServices;
using NygarnDemo.Services.Interfaces;
using NygarnDemo.Services.ProductServices;
using NygarnDemo.Services.User;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<IPatternService, PatternService>();
builder.Services.AddSingleton<ICrochetHookService, CrochetHookService>();
builder.Services.AddSingleton<IYarnService, YarnService>();
builder.Services.AddSingleton<IKnittingNeedleService, KnittingNeedleService>();
builder.Services.AddSingleton<IToolService, ToolService>();
builder.Services.AddDbContext<Microsoft.EntityFrameworkCore.DbContext>();
//builder.Services.AddDbContext<ToolDbContext>();
//builder.Services.AddDbContext<UserDbContext>();
//builder.Services.AddDbContext<NeedleDbContext>();
//builder.Services.AddDbContext<HookDbContext>();
//builder.Services.AddDbContext<OrderLineDbContext>();
builder.Services.AddSingleton<CrochetHookDbService, CrochetHookDbService>();
builder.Services.AddSingleton<ToolDbService, ToolDbService>();
builder.Services.AddSingleton<YarnDbService, YarnDbService>();
builder.Services.AddSingleton<UserDbService, UserDbService>();
builder.Services.AddSingleton<OrderLineDbService, OrderLineDbService>();
builder.Services.AddSingleton<KnittingNeedleDbService, KnittingNeedleDbService>();
builder.Services.AddSingleton<IUserService, UserService>();
builder.Services.Configure<CookiePolicyOptions>(options => {
    // This lambda determines whether user consent for non-essential cookies is needed for a given request. options.CheckConsentNeeded = context => true; 
    options.MinimumSameSitePolicy = SameSiteMode.None;

});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(cookieOptions => {
    cookieOptions.LoginPath = "/LogIn/LogInPage";

});

builder.Services.AddMvc().AddRazorPagesOptions(options => {
    //options.Conventions.AuthorizeFolder("/User");

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
