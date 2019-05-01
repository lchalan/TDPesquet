using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonProgAvancée
{
    class Pokemons : BddPokemon
    {

        private string Nom { get; set; }
        private int Pv { get; set; }
        private int Puissance { get; set; }
        private string Type { get; set; }
        private string Faiblesse { get; set; }

        public Pokemons(string nom, int pv, int puissance, string type, string faiblesse)
        {
            Nom = nom;
            Pv = pv;
            Puissance = puissance;
            Type = type;
            Faiblesse = faiblesse;
        }
        
    }
}
