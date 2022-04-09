using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        {
            //Area de Circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            //Tipos internos
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo: " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade: " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols: " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário: " + salario);

            int menorValorInt = int.MinValue; 
            Console.WriteLine("Menor valor do INT é: " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira: " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor valor Long: " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial: " + populacaoMundial);

            float precoComputador = 1299.99f; //Obrigatório a inclusão do f para tornar em Float
            Console.WriteLine("Preço do Computador: " + precoComputador);

            double valorDeMercadoApple = 1_000_000_000_000.00;
            Console.WriteLine("Valor de Mercado Apple: " + valorDeMercadoApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre as estrelas: " + distanciaEntreEstrelas);

            char letra = 'b'; //Aspas simples é somente para uma letra, a partir de duas vira string utilizando aspas duplas
            Console.WriteLine("Letra: " + letra);

            string texto = "Fortalecendo a base de conhecimento C#";
            Console.WriteLine(texto);
        }
    }
}
