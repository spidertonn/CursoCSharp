using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresAritmeticos
    {
        public static void Executar()
        {
            //Preço com desconto
            double preco = 1000;
            int imposto = 249;
            double desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine("O preço final é: {0}", totalComDesconto);

            //IMC
            double peso = 91.2;
            double altura = 1.75;
            double imc = peso / (altura * altura);
            Console.WriteLine("O IMC é: {0}",imc);

            //Número Par/Ímpar
            int par = 26;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);

        }
    }
}
