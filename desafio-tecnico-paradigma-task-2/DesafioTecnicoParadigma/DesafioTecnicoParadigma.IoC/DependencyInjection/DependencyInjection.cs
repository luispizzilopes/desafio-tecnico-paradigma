using DesafioTecnicoParadigma.Application.Interfaces.Services.BuilderTreeService;
using DesafioTecnicoParadigma.Application.Interfaces.Services.DisplayTreeService;
using DesafioTecnicoParadigma.Application.Interfaces.UseCases.BuilderTreeUseCase;
using DesafioTecnicoParadigma.Application.Interfaces.UseCases.DisplayTreeUseCase;
using DesafioTecnicoParadigma.Application.Interfaces.Validators.BuilderTreeValidator;
using DesafioTecnicoParadigma.Application.Services.BuilderTreeService;
using DesafioTecnicoParadigma.Application.Services.DisplayTreeService;
using DesafioTecnicoParadigma.Application.UseCases.BuilderTreeUseCase;
using DesafioTecnicoParadigma.Application.UseCases.DisplayTreeUseCase;
using DesafioTecnicoParadigma.Application.Validators.BuilderTreeValidator;
using Microsoft.Extensions.DependencyInjection;

namespace DesafioTecnicoParadigma.IoC.DependencyInjection;

public static class DependencyInjection
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddUseCases();
        services.AddServices(); 
        services.AddValidators();
    }

    public static void AddUseCases(this IServiceCollection services)
    {
        services.AddScoped<IBuilderTreeUseCase, BuilderTreeUseCase>();
        services.AddScoped<IDisplayTreeUseCase, DisplayTreeUseCase>();
    }

    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<IBuilderTreeService, BuilderTreeService>(); 
        services.AddScoped<IDisplayTreeService, DisplayTreeService>();
    }

    public static void AddValidators(this IServiceCollection services)
    {
        services.AddScoped<IBuilderTreeValidator, BuilderTreeValidator>();
    }
}
