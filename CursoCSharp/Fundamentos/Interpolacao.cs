using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 9800.00;

            Console.WriteLine("O "+ nome + " da marca " + marca + " custa " + preco + " reais.");
            Console.WriteLine("O {0} da marca {1} custa {2} reais. (segunda forma)",nome,marca,preco);
            Console.WriteLine($"A marca {marca} é legal!"); //Se coloca o mesmo nome da variavel declarada
            Console.WriteLine($"Calculei dentro do Writeline, 5 + 1: {5 + 1}");

        }
    }
}
