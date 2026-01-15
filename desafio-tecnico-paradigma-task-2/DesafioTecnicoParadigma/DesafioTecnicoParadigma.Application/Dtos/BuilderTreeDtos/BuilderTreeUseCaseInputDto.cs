namespace DesafioTecnicoParadigma.Application.Dtos.BuilderTreeDtos;

public class BuilderTreeUseCaseInputDto
{
    public int[]? Array { get; }

    public BuilderTreeUseCaseInputDto(){ }
    
    public BuilderTreeUseCaseInputDto(int[] array)
    {
        Array = array;
    }
}