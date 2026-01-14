using DesafioTecnicoParadigma.Application.Interfaces.UseCases.BuilderTreeUseCase;
using DesafioTecnicoParadigma.Application.Interfaces.UseCases.DisplayTreeUseCase;
using DesafioTecnicoParadigma.ConsoleUI;
using DesafioTecnicoParadigma.IoC.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Program
{
    public static void Main()
    {
        var host = CreateHostBuilder().Build();
        var serviceProvider = host.Services;
        
        var builderTreeUseCase = serviceProvider.GetRequiredService<IBuilderTreeUseCase>();
        var displayTreeUseCase = serviceProvider.GetRequiredService<IDisplayTreeUseCase>();
        
        var treeBuilderProcessor = new TreeBuilderProcessor(builderTreeUseCase, displayTreeUseCase);
        var menu = new ProgramMenu(treeBuilderProcessor);
        menu.ShowMenu();
    }
    
    private static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices((_, services) =>
            {
                services.AddApplication();
            });
    }
}