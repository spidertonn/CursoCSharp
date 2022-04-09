using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaForeach
    {
        public static void Executar()
        {
            var texto = "Olá, meu nome é Cleiton!";

            foreach (var letra in texto)
            {
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "Ana", "Bia", "Carlos" };

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }


        }
    }
}
