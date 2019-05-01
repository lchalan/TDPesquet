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
            //BddPokemon pokémonsdispo = new BddPokemon();
            //pokémonsdispo.creaBasePokemons();
            //Console.WriteLine(pokémonsdispo);
            ListeEquipe equipe = new ListeEquipe();
            equipe.creaEquipe();
            //Console.WriteLine(equipe);
            Console.ReadKey();
        }
    }
}
