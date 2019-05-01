using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonProgAvancée
{
    class Equipe : ListeEquipe
    {
        public string NomEquipe { get; set; }
        public Pokemons Pokémon1 { get; set; }
        public Pokemons Pokémon2 { get; set; }
        public Pokemons Pokémon3 { get; set; }
        
        public Equipe (string nom,Pokemons p1, Pokemons p2, Pokemons p3)
        {
            NomEquipe = nom;
            Pokémon1 = p1;
            Pokémon2 = p2;
            Pokémon3 = p3;
        }

        
    }
}
