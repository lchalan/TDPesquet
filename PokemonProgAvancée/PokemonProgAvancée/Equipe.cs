using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonProgAvancée
{
    class Equipe
    {
        public string Nom { get; set; }
        public Pokemons Pokméon1 { get; set; }
        public Pokemons Pokméon2 { get; set; }
        public Pokemons Pokméon3 { get; set; }

        public Random alea = new Random();

        List<Equipe> equipe = new List<Equipe> { };

        List<string> noms = new List<string> { "Red", "Leaf", "Ludwig" , "Ludvina", "Kalem", "Serena", "Florent", "Scout", "Silver", "Trovato", "Giovanni", "Lysandre", "Maladif", "Pierre", "Lem"};

        public Equipe (string nom)
        {

        }
    }
}
