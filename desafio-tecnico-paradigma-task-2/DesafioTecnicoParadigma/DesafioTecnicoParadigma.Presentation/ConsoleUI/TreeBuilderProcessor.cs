using DesafioTecnicoParadigma.Application.Dtos.BuilderTreeDtos;
using DesafioTecnicoParadigma.Application.Dtos.DisplayTreeDtos;
using DesafioTecnicoParadigma.Application.Interfaces.UseCases.BuilderTreeUseCase;
using DesafioTecnicoParadigma.Application.Interfaces.UseCases.DisplayTreeUseCase;

namespace DesafioTecnicoParadigma.ConsoleUI;

public class TreeBuilderProcessor
{
    private readonly IBuilderTreeUseCase _builderTreeUseCase;
    private readonly IDisplayTreeUseCase _displayTreeUseCase;

    public TreeBuilderProcessor(IBuilderTreeUseCase builderTreeUseCase, IDisplayTreeUseCase displayTreeUseCase)
    {
        _builderTreeUseCase = builderTreeUseCase;
        _displayTreeUseCase = displayTreeUseCase;
    }

    public void ProcessExampleArrays()
    {
        Console.WriteLine("\nCenário 1:");
        int[] firstArray = { 3, 2, 1, 6, 0, 5 };
        BuildAndDisplayTree(firstArray);

        Console.WriteLine("\nCenário 2:");
        int[] secondArray = { 7, 5, 13, 9, 1, 6, 4 };
        BuildAndDisplayTree(secondArray);
    }

    public void ProcessUserArray()
    {
        Console.WriteLine("\n=== Inserir seu próprio array ===");
        Console.Write("Digite os números separados por vírgula (ex: 3,2,1,6,0,5): ");
        var input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Entrada inválida. Tente novamente.");
            return;
        }

        try
        {
            var numbers = input.Split(',')
                .Select(s => s.Trim())
                .Where(s => !string.IsNullOrEmpty(s))
                .Select(s => int.Parse(s))
                .ToArray();

            Console.WriteLine($"\nArray inserido: [{string.Join(", ", numbers)}]");
            BuildAndDisplayTree(numbers);
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Certifique-se de digitar apenas números separados por vírgula.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao processar o array: {ex.Message}");
        }
    }

    private void BuildAndDisplayTree(int[] array)
    {
        try
        {
            var input = new BuilderTreeUseCaseInputDto(array);
            var tree = _builderTreeUseCase.Execute(input);
            
            Console.WriteLine($"Raiz: {tree.Root}");
            Console.WriteLine($"Galhos da esquerda: {string.Join(", ", tree.Left)}");
            Console.WriteLine($"Galhos da direita: {string.Join(", ", tree.Right)}\n");
            
            var inputDisplayTree = new DisplayTreeUseCaseInputDto(tree.Root, tree.Left, tree.Right);
            _displayTreeUseCase.Execute(inputDisplayTree);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao processar o cenário: {ex.Message}");
        }
    }
}
