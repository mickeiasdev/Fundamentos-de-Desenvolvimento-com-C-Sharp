using System;

using TP1;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=====================================================");
            Console.WriteLine("TP1 - C#");
            Console.WriteLine("=====================================================");
            Console.WriteLine("Digite o número do exercício (1-10) para executar:");
            Console.WriteLine("Ou digite '0' para sair.");
            Console.WriteLine("-----------------------------------------------------");

            string escolha = Console.ReadLine();

            Console.Clear();

            switch (escolha)
            {
                case "1":
                    E1.Run();
                    break;
                case "2":
                    E2.Run();
                    break;
                case "3":
                    E3.Run();
                    break;
                case "4":
                    E4.Run();
                    break;
                case "5":
                    E5.Run();
                    break;
                case "6":
                    E6.Run();
                    break;
                case "7":
                    E7.Run();
                    break;
                case "8":
                    E8.Run();
                    break;
                case "9":
                    E9.Run();
                    break;
                case "10":
                    E10.Run();
                    break;
                case "0":
                    Console.WriteLine("Finalizando.");
                    return;
                default:
                    Console.WriteLine("Opção inválida! Tente um número de 1 a 10.");
                    break;
            }
            

            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("Pressione Enter para voltar ao menu...");
            Console.ReadLine();
        }
    }
}
