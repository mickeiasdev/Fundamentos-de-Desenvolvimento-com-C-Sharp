using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class E9
    {
        public static void Run()
        {
            Console.WriteLine("--- Exercício 9: Declaração de Variáveis e Tipos ---");
            Console.WriteLine();

            int idade;
            string nome;
            double altura;

            idade = 22;
            nome = "Mickeias";
            altura = 1.75;

            Console.WriteLine("Valores armazenados:");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade} anos");
            Console.WriteLine($"Altura: {altura}m");
        }
    }
}
