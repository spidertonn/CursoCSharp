using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        //STATIC faz o método pertencer a Classe e não ao objeto (chamada direta ao método)

        //Metodo de Classe ou Método Estático
        public static int Somar(int a, int b)
        {
            return a + b;
        }
        //Metodo de Instância
        
        //public int Somar(int a, int b)
        //{
        //    return a + b;
        //}

        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }


    }

    internal class MetodosEstaticos
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(5, 5);
            Console.WriteLine($"O Resultado é: {resultado}");
            Console.WriteLine(CalculadoraEstatica.Somar(2, 3));
        }
    }
}
