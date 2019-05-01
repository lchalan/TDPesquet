using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonProgAvancée
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salut");
            BddPokemon pokméonsdispo = new BddPokemon();
            Console.WriteLine(pokméonsdispo);
            Console.ReadKey();
        }
    }
}
