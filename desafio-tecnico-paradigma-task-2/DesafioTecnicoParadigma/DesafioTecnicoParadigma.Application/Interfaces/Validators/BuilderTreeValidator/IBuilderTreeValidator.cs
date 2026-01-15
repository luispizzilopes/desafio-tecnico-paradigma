using DesafioTecnicoParadigma.Application.Dtos.BuilderTreeDtos;
using DesafioTecnicoParadigma.BuildingBlocks.Common;

namespace DesafioTecnicoParadigma.Application.Interfaces.Validators.BuilderTreeValidator;

public interface IBuilderTreeValidator
{
    ValidationResult Validate(BuilderTreeUseCaseInputDto input);
}
