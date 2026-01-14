using DesafioTecnicoParadigma.Application.Dtos.BuilderTreeDtos;
using DesafioTecnicoParadigma.Application.Interfaces.Validators.BuilderTreeValidator;

namespace DesafioTecnicoParadigma.Application.Validators.BuilderTreeValidator;

public class BuilderTreeValidator : IBuilderTreeValidator
{
    public ValidationResult Validate(BuilderTreeUseCaseInputDto input)
    {
        var result = new ValidationResult { IsValid = true };

        if (input == null)
        {
            result.IsValid = false;
            result.Errors.Add("Input cannot be null");
            return result;
        }

        if (input.Array == null)
        {
            result.IsValid = false;
            result.Errors.Add("Array cannot be null");
            return result;
        }

        if (input.Array.Length == 0)
        {
            result.IsValid = false;
            result.Errors.Add("Array cannot be empty");
            return result;
        }

        if (input.Array.Length > 1000)
        {
            result.IsValid = false;
            result.Errors.Add("Array length cannot exceed 1000 elements");
        }

        return result;
    }
}
