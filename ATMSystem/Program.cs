// See https://aka.ms/new-console-template for more information
using ATMSystem.Business.Abstract;
using ATMSystem.Business.Concrete;
using ATMSystem.Data.Abstract;
using ATMSystem.Data.Concrete;
using ATMSystem.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


IHost host = CreateHostBuilder(args).Build();
var scope = host.Services.CreateScope();
var services = scope.ServiceProvider;

try
{
    services.GetRequiredService<BankApp>().Execute();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


IHostBuilder CreateHostBuilder(string[] strings)
{
    return Host.CreateDefaultBuilder()
    .ConfigureServices((_, services) =>
    {
        services.AddScoped<ICardRepository, CardRepository>();
        services.AddScoped<ICardService, CardManager>();
        services.AddScoped<IATMService, ATMManager>();
        services.AddSingleton<BankApp>();
    });
}






