using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaIfElse
    {
        public static void Executar()
        {
            Console.Write("Digite a nota do aluno: ");

            string entrada;
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);


            if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado");
                Console.WriteLine("Não fez mais que sua obrigação! :)");
            }
            else
            {
                Console.WriteLine("Recuperação! :(");
                Console.WriteLine("Precisa estudar mais! :(");
            }
        }
    }
}
