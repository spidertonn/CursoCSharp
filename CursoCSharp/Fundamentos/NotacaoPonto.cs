﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "Olá".ToUpper().Insert(3, " World!").Replace("World!", "Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine("Total de Caracteres".Length);//Contabiliza espaços

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
        }
    }
}
