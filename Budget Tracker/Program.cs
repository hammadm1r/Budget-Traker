using BudgetApp.Settings;
using BudgetApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Configure MongoDB
builder.Services.Configure<MongoDBSettings>(
    builder.Configuration.GetSection("MongoDBSettings"));
builder.Services.AddSingleton<TransactionService>();

// MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.MapDefaultControllerRoute();
app.Run();
