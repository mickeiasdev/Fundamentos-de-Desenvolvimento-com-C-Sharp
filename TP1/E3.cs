using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class E3
    {
        public static void Run()
        {
            Console.WriteLine("--- Exercício 3: Comparando IDEs (VS, VS Code, Rider) ---");
            Console.WriteLine();

            Console.WriteLine("[ Visual Studio (VS 2022) ]");
            Console.WriteLine("---------------------------");
            Console.WriteLine("É o 'paizão' de todos. A integração com .NET e C# é 100% perfeita.");
            Console.WriteLine("O 'IntelliSense' (auto-complete) dele é fenomenal e o Debugger (depurador) é o mais completo.");
            Console.WriteLine("A versão 'Community' é grátis e tem tudo que um iniciante precisa.");
            Console.WriteLine("Como desvantagem, ele é pesado. Demora pra abrir e consome bastante RAM,");
            Console.WriteLine("sendo focado quase 100% no mundo Microsoft.");
            Console.WriteLine("\n");

            Console.WriteLine("[ Visual Studio Code (VS Code) ]");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("É um 'canivete suíço'. Super leve, rápido e funciona pra TUDO (JS, Python, Go, C#, etc.).");
            Console.WriteLine("É gratuito, roda liso no Mac e Linux e é customizável com milhões de extensões.");
            Console.WriteLine("A desvantagem é que, pra C#, ele é 'básico' sozinho e depende da extensão da Microsoft.");
            Console.WriteLine("É mais um 'editor de código' turbinado do que uma 'IDE' completa como o VS.");
            Console.WriteLine("\n");

            Console.WriteLine("[ Rider (da JetBrains) ]");
            Console.WriteLine("--------------------------");
            Console.WriteLine("É extremamente inteligente, com as melhores ferramentas de 'refatoração' (melhorar código).");
            Console.WriteLine("É bem mais rápido que o VS e funciona 100% igual no Windows, Mac e Linux.");
            Console.WriteLine("A principal desvantagem é ser pago (e não é barato).");
            Console.WriteLine("Pode ser 'inteligente até demais' para quem está só começando.");
        }
    }
}
