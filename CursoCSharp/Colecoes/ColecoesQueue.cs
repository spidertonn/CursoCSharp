using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("Cleiton");
            fila.Enqueue("Nescau");
            fila.Enqueue("Zelda");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count());

            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count());

            foreach(var pessoa in fila) {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Pepino");
            salada.Enqueue(true);
            salada.Enqueue('a');

            Console.WriteLine(salada.Contains("Pepino"));

        }
    }
}
