using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Membros
    {
        public static void Executar()
        {
            Pessoa fulano = new Pessoa();
            fulano.Nome = "Cleiton";
            fulano.Idade = 36;

            //Console.WriteLine($"{fulano.Nome} tem {fulano.Idade} anos.");

            fulano.ApresentarNoConsole();

            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Marcele";
            sicrano.Idade = 38;

            var apresentacaoDoSicrano = sicrano.Apresentar();

            Console.WriteLine(apresentacaoDoSicrano);


        }
    }
}
