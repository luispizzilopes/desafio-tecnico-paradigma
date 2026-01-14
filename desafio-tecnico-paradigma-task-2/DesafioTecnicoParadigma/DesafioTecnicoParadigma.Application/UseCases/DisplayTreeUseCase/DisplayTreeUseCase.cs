using DesafioTecnicoParadigma.Application.Dtos.DisplayTreeDtos;
using DesafioTecnicoParadigma.Application.Interfaces.Services.DisplayTreeService;
using DesafioTecnicoParadigma.Application.Interfaces.UseCases.DisplayTreeUseCase;

namespace DesafioTecnicoParadigma.Application.UseCases.DisplayTreeUseCase;

public class DisplayTreeUseCase : IDisplayTreeUseCase
{
    private readonly IDisplayTreeService _displayTreeService;

    public DisplayTreeUseCase(IDisplayTreeService displayTreeService)
    {
        _displayTreeService = displayTreeService;
    }

    public void Execute(DisplayTreeUseCaseInputDto input)
    {
        _displayTreeService.DisplayTree(input);
    }
}