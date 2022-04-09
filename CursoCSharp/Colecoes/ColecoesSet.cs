using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{

    class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 69.9);

            //Set não aceita itens repetidos e não é indexado (não possui indices)
            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                new Produto ("Camiseta", 49.9),
                new Produto ("Jogo Elden Ring PS5", 300.0),
                new Produto ("Poster",25.9)};

            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);
       

            foreach (var item in carrinho)
            {
          
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }

            carrinho.Add (livro);
            Console.WriteLine(carrinho.Count);

         
        }
    }
}
