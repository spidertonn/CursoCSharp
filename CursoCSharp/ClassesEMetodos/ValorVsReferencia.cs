using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Dependente {
        public string Nome;
        public int Idade;
    }

    class ValorVsReferencia
    {
        public static void Executar()
        {
            int numero = 3;
            int copiaDoNumero = numero;

            Console.WriteLine($"{numero} {copiaDoNumero}");
            numero++;
            Console.WriteLine($"{numero} {copiaDoNumero}");

            Dependente dependente = new Dependente
            {
                Nome = "Cleiton",
                Idade = 36
            };

            Dependente copiaDependente = dependente;

            Console.WriteLine($"{dependente.Nome} {copiaDependente.Nome}");
            Console.WriteLine($"{dependente.Idade} {copiaDependente.Idade}");

            copiaDependente.Nome = "Danilo";
            dependente.Idade = 20;

            Console.WriteLine($"{dependente.Nome} {copiaDependente.Nome}");
            Console.WriteLine($"{dependente.Idade} {copiaDependente.Idade}");

        }
    }
}
