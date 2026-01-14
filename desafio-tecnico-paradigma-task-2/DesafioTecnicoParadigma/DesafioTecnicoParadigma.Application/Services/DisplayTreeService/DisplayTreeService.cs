using DesafioTecnicoParadigma.Application.Dtos.DisplayTreeDtos;
using DesafioTecnicoParadigma.Application.Interfaces.Services.DisplayTreeService;
using DesafioTecnicoParadigma.Constants;

namespace DesafioTecnicoParadigma.Application.Services.DisplayTreeService;

public class DisplayTreeService : IDisplayTreeService
{
    public void DisplayTree(DisplayTreeUseCaseInputDto input)
    {
        var dimensions = CalculateDimensions(input.Left, input.Right);
        var screen = InitializeScreen(dimensions.Height, dimensions.Width);
        
        var center = dimensions.Width / 2;
        
        DrawRoot(screen, input.Root, center);
        DrawLeftBranches(screen, input.Left, center);
        DrawRightBranches(screen, input.Right, center);
        
        PrintScreen(screen);
    }
    
    private (int Height, int Width) CalculateDimensions(int[] left, int[] right)
    {
        int height = Math.Max(left.Length, right.Length) * (DisplayConstants.VerticalOffset + 1);
        return (height, DisplayConstants.DefaultWidth);
    }
    
    private char[,] InitializeScreen(int height, int width)
    {
        var screen = new char[height, width];
        
        for (int i = 0; i < height; i++)
        for (int j = 0; j < width; j++)
            screen[i, j] = ' ';
            
        return screen;
    }
    
    private void DrawRoot(char[,] screen, int root, int center)
    {
        WriteNumber(screen, 0, center, root);
    }
    
    private void DrawLeftBranches(char[,] screen, int[] left, int center)
    {
        int row = 1;
        int column = center - DisplayConstants.HorizontalOffset;

        foreach (var number in left)
        {
            screen[row, column + 1] = '/';
            row++;
            WriteNumber(screen, row, column, number);
            row += DisplayConstants.VerticalOffset - 1;
            column -= DisplayConstants.HorizontalOffset;
        }
    }
    
    private void DrawRightBranches(char[,] screen, int[] right, int center)
    {
        int row = 1;
        int column = center + DisplayConstants.HorizontalOffset;

        foreach (var number in right)
        {
            screen[row, column - 1] = '\\';
            row++;
            WriteNumber(screen, row, column, number);
            row += DisplayConstants.VerticalOffset - 1;
            column += DisplayConstants.HorizontalOffset;
        }
    }
    
    private void PrintScreen(char[,] screen)
    {
        for (int i = 0; i < screen.GetLength(0); i++)
        {
            for (int j = 0; j < screen.GetLength(1); j++)
                Console.Write(screen[i, j]);

            Console.WriteLine();
        }
    }
    
    private void WriteNumber(char[,] screen, int row, int column, int number)
    {
        var text = number.ToString();
        for (int i = 0; i < text.Length; i++)
            screen[row, column + i] = text[i];
    }
}