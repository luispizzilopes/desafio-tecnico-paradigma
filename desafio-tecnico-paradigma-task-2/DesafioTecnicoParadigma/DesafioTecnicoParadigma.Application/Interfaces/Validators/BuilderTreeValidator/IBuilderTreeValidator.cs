using DesafioTecnicoParadigma.Application.Dtos.BuilderTreeDtos;

namespace DesafioTecnicoParadigma.Application.Interfaces.Validators.BuilderTreeValidator;

public interface IBuilderTreeValidator
{
    ValidationResult Validate(BuilderTreeUseCaseInputDto input);
}

public class ValidationResult
{
    public bool IsValid { get; set; }
    public List<string> Errors { get; set; } = new();
}
