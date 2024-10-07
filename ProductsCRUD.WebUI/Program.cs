using Microsoft.EntityFrameworkCore;
using ProductsCRUD.WebUI.Abstractions;
using ProductsCRUD.WebUI.Components;
using ProductsCRUD.WebUI.Data;
using ProductsCRUD.WebUI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<DatabaseContext>(options =>
{
    options.UseMySql(
        builder.Configuration.GetConnectionString("MySQL"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("MySQL")),
        args => args.MigrationsAssembly(typeof(DatabaseContext).Assembly.FullName));
});

builder.Services.AddScoped<IProductsService, ProductsService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
