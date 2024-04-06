using AutoMapper;
using InstrumentationAccountingSystem2.BusinessLogic.Interfaces;
using InstrumentationAccountingSystem2.BusinessLogic.Services;
using InstrumentationAccountingSystem2.Mapper;
using InstrumentationAccountingSystem2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

string connection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

//builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
//    .AddRoles<IdentityRole>()
//    .AddEntityFrameworkStores<AuthDbContext>();

//builder.Services.Configure<IdentityOptions>(options =>
//{
//    options.Password.RequireUppercase = false;
//    options.Password.RequireLowercase = false;
//    options.Password.RequireDigit = false;
//    options.Password.RequireNonAlphanumeric = false;
//    options.Password.RequiredUniqueChars = 0;
//});

//builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<ITypeService, TypeService>();
builder.Services.AddTransient<ILocationService, LocationService>();
builder.Services.AddTransient<IInstrumentationService, InstrumentationService>();
builder.Services.AddTransient<IVerificationService, VerificationService>();
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();

var mappingConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MapperProfile());
});
var mapper = mappingConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession();

//app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

//using (var scope = app.Services.CreateScope())
//{
//    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
//    var roles = new[] { "Admin", "Member" };
//    foreach (var role in roles)
//    {
//        if (!await roleManager.RoleExistsAsync(role))
//            await roleManager.CreateAsync(new IdentityRole(role));
//    }
//}

app.Run();
