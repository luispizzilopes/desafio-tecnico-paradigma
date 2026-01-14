namespace DesafioTecnicoParadigma.Application.Dtos.DisplayTreeDtos;

public class DisplayTreeUseCaseInputDto
{
    public int Root { get; }
    public int[] Left { get; }
    public int[] Right { get; }

    public DisplayTreeUseCaseInputDto() { }

    public DisplayTreeUseCaseInputDto(int root, int[] left, int[] right)
    {
        Root = root;
        Left = left;
        Right = right;
    }
}