namespace DesafioTecnicoParadigma.Application.Dtos.BuilderTreeDtos;

public class BuilderTreeUseCaseOutputDto
{
    public int Root { get; init; }
    public int[]? Left { get; init; }
    public int[]? Right { get; init; }
}