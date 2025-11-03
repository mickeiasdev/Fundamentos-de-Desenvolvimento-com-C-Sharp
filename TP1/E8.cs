using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class E8
    {
        public static void Run()
        {
            Console.WriteLine("--- Exercício 8: Ler Entrada do Usuário ---");
            Console.WriteLine();

            Console.Write("Por favor, digite seu nome: ");

            string nomeUsuario = Console.ReadLine();

            Console.WriteLine($"Olá, {nomeUsuario}! Bem-vindo(a).");
        }
    }
}
