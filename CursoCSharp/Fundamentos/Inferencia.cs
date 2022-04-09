using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Inferencia
    {
        public static void Executar()
        {
            var nome = "Cleiton";
            // nome = 123;
            Console.WriteLine(nome);

            //int idade
            var idade = 36; //Obrigatório declarar o conteudo da váriavel para a inferencia ocorrer
            Console.WriteLine(idade);

            int a;
            a = 3;

            int b = 2;

            Console.WriteLine(a + b);


            
        }
    }
}
