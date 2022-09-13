using JaizBank.Application.JaizBank.Interfaces;
using JaizBank.Application.JaizBank.Repositories;
using JaizBank.Application.JaizBank.Services;
using JaizBankPersistence.Context;
using JaizBankUI.JaizBankViewMappingConfig;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapperConfiguration();
builder.Services.AddScoped<ITransactionRepository, TransactionsRepository>();
builder.Services.AddScoped<ITransactionService, TransactionService>();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
