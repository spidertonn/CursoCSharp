using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public enum Genero { Acao, Aventura, Terror, Drama, Comedia, Ficcao};

    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;
    }


    class ExemploEnum
    {
        public static void Executar()
        {
            int id = (int)Genero.Comedia;
            Console.WriteLine(id);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Procurando Nemo";
            filmeParaFamilia.GeneroDoFilme = Genero.Comedia;

            Console.WriteLine("{0} é {1}!", filmeParaFamilia.Titulo, filmeParaFamilia.GeneroDoFilme);

        }
    }
}
