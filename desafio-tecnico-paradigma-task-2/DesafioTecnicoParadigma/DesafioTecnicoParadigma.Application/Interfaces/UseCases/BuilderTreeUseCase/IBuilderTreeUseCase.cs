using DesafioTecnicoParadigma.Application.Dtos.BuilderTreeDtos;

namespace DesafioTecnicoParadigma.Application.Interfaces.UseCases.BuilderTreeUseCase;

public interface IBuilderTreeUseCase
{
    BuilderTreeUseCaseOutputDto Execute(BuilderTreeUseCaseInputDto input);
}
