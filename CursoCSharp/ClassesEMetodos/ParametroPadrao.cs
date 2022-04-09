﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class ParametroPadrao
    {
        public static int Somar(int a = 1, int b =1)//valor padrão inserido no método
        {
            return a + b;
        }

        public static void Executar()
        {
            Console.WriteLine(Somar(10, 22));
            Console.WriteLine(Somar(50));
            Console.WriteLine(Somar());
        }
    }
}
