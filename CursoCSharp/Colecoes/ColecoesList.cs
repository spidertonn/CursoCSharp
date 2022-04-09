using System;
using System.Collections.Generic;//Usado para utilizar o List
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }

    internal class ColecoesList
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 69.9);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto> {
                new Produto ("Camiseta", 49.9),
                new Produto ("Jogo Elden Ring PS5", 300.0),
                new Produto ("Poster",25.9)};

            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3);

            foreach (var item in carrinho)
            {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add (livro);
            Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}
