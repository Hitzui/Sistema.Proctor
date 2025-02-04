using Microsoft.Extensions.DependencyInjection;
using Sistema.Proctor.Data.Entities;
using Sistema.Proctor.Data.Repositories;

namespace Sistema.Proctor.Data;

public class DependenciasGlobales
{
    private static readonly Lazy<DependenciasGlobales> instance = new(() => new DependenciasGlobales());

    public static DependenciasGlobales Instance => instance.Value;

    private readonly IServiceProvider serviceProvider;

    private DependenciasGlobales()
    {
        // Configurar el contenedor de DI
        var serviceCollection = new ServiceCollection();

        // Registrar tus servicios y repositorios aquí
        serviceCollection.AddSingleton<IUnitOfWork, UnitOfWork>();
        serviceCollection.AddSingleton<DataContextProctor>();
        // Agrega más servicios y repositorios según sea necesario

        serviceProvider = serviceCollection.BuildServiceProvider();
    }

    public T? GetService<T>()
    {
        return serviceProvider.GetService<T>();
    }
}