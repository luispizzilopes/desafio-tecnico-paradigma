using DesafioTecnicoParadigma.ConsoleUI;

namespace DesafioTecnicoParadigma.ConsoleUI;

public class ProgramMenu
{
    private readonly TreeBuilderProcessor _treeBuilderProcessor;

    public ProgramMenu(TreeBuilderProcessor treeBuilderProcessor)
    {
        _treeBuilderProcessor = treeBuilderProcessor;
    }

    public void ShowMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                       MENU DO SISTEMA                        ║");
            Console.WriteLine("╠══════════════════════════════════════════════════════════════╣");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║  [1] Usar Arrays de Exemplo                                  ║");
            Console.WriteLine("║  [2] Inserir seu Próprio Array                               ║");
            Console.WriteLine("║  [3] Sair do Sistema                                         ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            Console.WriteLine();
            Console.Write("Escolha uma opção (1-3): ");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Executando Arrays de Exemplo...\n");
                    _treeBuilderProcessor.ProcessExampleArrays();
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Modo de Entrada Personalizada\n");
                    _treeBuilderProcessor.ProcessUserArray();
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                    break;
                case "3":
                    Console.Clear();
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida! Por favor, escolha entre 1 e 3.");
                    break;
            }
        }
    }
}