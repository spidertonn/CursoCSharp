using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;

            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaQuebrada = (int)nota;//Perde informação na conversão
            Console.WriteLine("Nota Quebrada: {0}", notaQuebrada);

            Console.WriteLine("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);

            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado Convertido: {0}",idadeInteiro);

            Console.Write("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero); //converte a string palavra e joga na variavel inteira numero
            Console.WriteLine("Resultado do número 1: {0}", numero);

            //Forma otimizada abaixo
            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2); //converte a string palavra e joga na variavel inteira numero
            Console.WriteLine("Resultado do número 2: {0}", numero2);
        }
    }
}
