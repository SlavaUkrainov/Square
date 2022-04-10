using Data.Context;
using Data.Repository;
using Domain.Entities;
using Domain.Repository;
using Domain.UseCases;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Presentation;

public class DependencyInjectionModule
{
    public ServiceProvider GetServiceProvider()
    {
        var serviceCollection = BuildModule();
        return serviceCollection.BuildServiceProvider();
    }

    private IServiceCollection BuildModule()
    {
        var serviceCollection = new ServiceCollection();
        
        serviceCollection.AddSingleton(typeof(DbContext), typeof(Context));
        serviceCollection.AddSingleton(new ContextFactory());
        serviceCollection.AddSingleton<IRepository<Square>>(sp => new Repository(sp.GetService<ContextFactory>()));
        
        serviceCollection.AddSingleton<GetSquareUseCase>();

        return serviceCollection;
    }
}