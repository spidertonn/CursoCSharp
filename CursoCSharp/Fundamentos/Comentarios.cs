using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Comentarios
    {
        public static void Executar()
           //Cuidado com comentários desnecessários

           /// <summary>
           /// Comentários XML
           /// </summary>
           
            /*
             * Esse é um comentário de 
             * multiplas
             * linhas
             */

        {
            Console.WriteLine("Código claro é sempre melhor!");
            Console.WriteLine("C# tem XML Comments");
        }
    }
}
