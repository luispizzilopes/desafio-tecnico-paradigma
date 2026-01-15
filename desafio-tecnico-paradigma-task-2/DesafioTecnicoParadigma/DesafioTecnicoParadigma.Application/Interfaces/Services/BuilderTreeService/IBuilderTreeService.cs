using DesafioTecnicoParadigma.Application.Dtos.BuilderTreeDtos;

namespace DesafioTecnicoParadigma.Application.Interfaces.Services.BuilderTreeService;

public interface IBuilderTreeService
{
    BuilderTreeUseCaseOutputDto BuildTree(int[] array);
}