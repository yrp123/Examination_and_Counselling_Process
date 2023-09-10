using Examination_and_Counselling_Process.ContextDBConfig;
using Examination_and_Counselling_Process.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var dbConnection = builder.Configuration.GetConnectionString("dbConnection");

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Exam_and_Counselling_DB_Context>(options => options.UseSqlServer(dbConnection));
builder.Services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<Exam_and_Counselling_DB_Context>();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(20);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseSession();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
