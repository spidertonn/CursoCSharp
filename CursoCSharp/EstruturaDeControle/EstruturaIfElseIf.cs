using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaIfElseIf
    {
        public static void Executar()
        {
            Console.Write("Digite a nota do aluno: ");

            string entrada;
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if (nota >= 9.0)
            {
                Console.WriteLine("Aprovado");
                Console.WriteLine("Quadro de Honra! :)");
            }
            else if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado");
                Console.WriteLine("Parabéns! :)");
            }
            else if (nota >= 5.0)
            {
                Console.WriteLine("Recuperação! :(");
                Console.WriteLine("Precisa estudar mais! :(");
            }
            else
            {
                Console.WriteLine("Repetiu de ano!");
            }
        }
    }
}
