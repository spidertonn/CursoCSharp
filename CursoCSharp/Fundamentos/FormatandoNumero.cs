using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; // Biblioteca para utilizar CultureInfo

namespace CursoCSharp.Fundamentos
{
    internal class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));//Arredonda para 1 casa decimal
            Console.WriteLine(valor.ToString("C")); //Valor monetário
            Console.WriteLine(valor.ToString("P")); //Percentual
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C0", cultura));//valor monetario padrão sem casa decimal

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));//Insere zeros a esquerda 
        }
    }
}
