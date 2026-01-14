using DesafioTecnicoParadigma.Application.Dtos.DisplayTreeDtos;

namespace DesafioTecnicoParadigma.Application.Interfaces.Services.DisplayTreeService;

public interface IDisplayTreeService
{
    void DisplayTree(DisplayTreeUseCaseInputDto treeData);
}