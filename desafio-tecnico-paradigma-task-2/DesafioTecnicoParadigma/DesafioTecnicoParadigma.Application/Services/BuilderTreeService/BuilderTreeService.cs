using System.Linq;
using DesafioTecnicoParadigma.Application.Dtos.BuilderTreeDtos;
using DesafioTecnicoParadigma.Application.Interfaces.Services.BuilderTreeService;

namespace DesafioTecnicoParadigma.Application.Services.BuilderTreeService;

public class BuilderTreeService : IBuilderTreeService
{
    public BuilderTreeUseCaseOutputDto BuildTree(int[] array)
    {
        int maxIndex = FindMaxValueIndex(array);
        var (root, leftArray, rightArray) = SplitArrayAtMaxIndex(array, maxIndex);
        var (sortedLeft, sortedRight) = SortAndReverseArrays(leftArray, rightArray);
        
        return CreateTreeOutput(root, sortedLeft, sortedRight);
    }

    private int FindMaxValueIndex(int[] array)
    {
        int maxIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex])
                maxIndex = i;
        }
        return maxIndex;
    }

    private (int root, int[] leftArray, int[] rightArray) SplitArrayAtMaxIndex(int[] array, int maxIndex)
    {
        int root = array[maxIndex];
        int[] leftArray = array.Take(maxIndex).ToArray();
        int[] rightArray = array.Skip(maxIndex + 1).ToArray();
        
        return (root, leftArray, rightArray);
    }

    private (int[] sortedLeft, int[] sortedRight) SortAndReverseArrays(int[] leftArray, int[] rightArray)
    {
        Array.Sort(leftArray);
        Array.Reverse(leftArray);
        
        Array.Sort(rightArray);
        Array.Reverse(rightArray);
        
        return (leftArray, rightArray);
    }

    private BuilderTreeUseCaseOutputDto CreateTreeOutput(int root, int[] leftArray, int[] rightArray)
    {
        return new BuilderTreeUseCaseOutputDto
        {
            Root = root,
            Left = leftArray,
            Right = rightArray
        };
    }
}