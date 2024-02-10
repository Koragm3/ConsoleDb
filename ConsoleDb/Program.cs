using ConsoleDb.Context;
using ConsoleDb.Repositories;
using ConsoleDb.Services;
using ConsoleDb.UI.Navigation;
using ConsoleDb.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder().ConfigureServices(services =>
{
    services.AddDbContext<DataContext>(x => x.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Projects\ConsoleDb\ConsoleDb\Data\database.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True"));

    services.AddScoped<AddressRepository>();
    services.AddScoped<CategoryRepository>();
    services.AddScoped<ProductRepository>();
    services.AddScoped<RoleRepository>();
    services.AddScoped<CustomerRepository>();

    services.AddScoped<AddressService>();
    services.AddScoped<CategoryService>();
    services.AddScoped<ProductService>();
    services.AddScoped<RoleService>();
    services.AddScoped<CustomerService>();
    services.AddSingleton<MainScreen>();

    services.AddSingleton<Navigator>();
    services.AddSingleton<RegisterCustomerUI>();
}).Build();

var mainUI = builder.Services.GetRequiredService<MainScreen>();
mainUI.Render();
