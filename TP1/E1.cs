using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class E1
    {
        public static void Run()
        {
            Console.WriteLine("--- Exercício 1: Relação entre C# e .NET ---");
            Console.WriteLine();

            Console.WriteLine("O que é o .NET:");
            Console.WriteLine("----------------");
            Console.WriteLine(".NET é uma plataforma de desenvolvimento gratuita, de código aberto e multiplataforma da Microsoft.");
            Console.WriteLine("É um ecossistema abrangente para criar diversos tipos de aplicações (web, desktop, móveis, etc.).");
            Console.WriteLine();

            Console.WriteLine("A integração do C# com o .NET:");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("C# é a linguagem de programação primária e moderna projetada para o .NET.");
            Console.WriteLine("O código C# é compilado para uma Linguagem Intermediária (CIL), que é então executada pelo .NET.");
            Console.WriteLine();

            Console.WriteLine("O papel do CLR (Common Language Runtime):");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("O CLR é o 'motor' de execução do .NET, responsável por gerenciar o código CIL.");
            Console.WriteLine("Suas funções principais são a compilação JIT (Just-In-Time) para código nativo,");
            Console.WriteLine("o gerenciamento automático de memória (Garbage Collector) e a segurança da aplicação.");
            Console.WriteLine();

            Console.WriteLine("O papel da FCL (Framework Class Library):");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("A FCL (ou BCL no .NET moderno) é a biblioteca de classes base reutilizáveis.");
            Console.WriteLine("Ela fornece funcionalidades prontas para tarefas comuns, como manipulação de arquivos,");
            Console.WriteLine("acesso a redes e operações de banco de dados, acelerando o desenvolvimento.");
        }
    }
}
