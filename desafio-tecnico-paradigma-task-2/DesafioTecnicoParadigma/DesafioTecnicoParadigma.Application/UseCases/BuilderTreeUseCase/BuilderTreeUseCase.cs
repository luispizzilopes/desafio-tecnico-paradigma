using DesafioTecnicoParadigma.Application.Dtos.BuilderTreeDtos;
using DesafioTecnicoParadigma.Application.Interfaces.Services.BuilderTreeService;
using DesafioTecnicoParadigma.Application.Interfaces.UseCases.BuilderTreeUseCase;
using DesafioTecnicoParadigma.Application.Interfaces.Validators.BuilderTreeValidator;
using DesafioTecnicoParadigma.Domain.Exceptions;

namespace DesafioTecnicoParadigma.Application.UseCases.BuilderTreeUseCase;

public class BuilderTreeUseCase : IBuilderTreeUseCase
{
    private readonly IBuilderTreeService _builderTreeService;
    private readonly IBuilderTreeValidator _validator;

    public BuilderTreeUseCase(IBuilderTreeService builderTreeService, IBuilderTreeValidator validator)
    {
        _builderTreeService = builderTreeService;
        _validator = validator;
    }

    public BuilderTreeUseCaseOutputDto Execute(BuilderTreeUseCaseInputDto input)
    {
        var validationResult = _validator.Validate(input);
        
        if (!validationResult.IsValid)
            throw new DomainException(string.Join(", ", validationResult.Errors));
        
        return _builderTreeService.BuildTree(input.Array!);
    }
}
