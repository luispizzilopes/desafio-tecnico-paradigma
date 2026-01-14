using DesafioTecnicoParadigma.Application.Dtos.DisplayTreeDtos;

namespace DesafioTecnicoParadigma.Application.Interfaces.UseCases.DisplayTreeUseCase;

public interface IDisplayTreeUseCase
{
    void Execute(DisplayTreeUseCaseInputDto input);
}
