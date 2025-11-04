using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class E2
    {
        public static void Run()
        {
            Console.WriteLine("--- Exercício 2: Componentes para Desenvolvimento Web com C# ---");
            Console.WriteLine();

            Console.WriteLine("[ ASP.NET Core ]");
            Console.WriteLine("----------------");
            Console.WriteLine("É o 'chassi' principal. É o framework (a estrutura) que a gente usa pra construir qualquer coisa");
            Console.WriteLine("para web com C#. Seja um site (tipo Razor Pages), uma API (pra apps mobile consumirem) ou");
            Console.WriteLine("um app web mais complexo (MVC). Ele é rápido, moderno e roda em qualquer lugar (Windows, Linux, Mac).");
            Console.WriteLine("É o sucessor 'bombado' do antigo ASP.NET.");
            Console.WriteLine();

            Console.WriteLine("[ Entity Framework Core (EF Core) ]");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("É o 'tradutor' de banco de dados. Em vez de você ficar escrevendo SQL 'na mão' (tipo 'SELECT * FROM...'),");
            Console.WriteLine("você mexe com seus objetos C# (tipo 'minhaListaDeUsuarios.Buscar(id)') e o EF Core se vira");
            Console.WriteLine("para traduzir isso pro idioma do banco de dados (SQL Server, MySQL, etc.).");
            Console.WriteLine("Isso é chamado de ORM (Object-Relational Mapper) e salva um tempo absurdo.");
            Console.WriteLine();

            Console.WriteLine("[ Razor Pages ]");
            Console.WriteLine("---------------");
            Console.WriteLine("É um jeito mais direto e moderno (dentro do ASP.NET Core) de fazer páginas web.");
            Console.WriteLine("Funciona assim: cada página é um par de arquivos (um .cshtml pro HTML, e um .cs pro código C#).");
            Console.WriteLine("É mais simples que o padrão MVC (Model-View-Controller) e ótimo pra apps focados em formulários");
            Console.WriteLine("(tipo páginas de cadastro, login, etc.).");
        }
    }
}
