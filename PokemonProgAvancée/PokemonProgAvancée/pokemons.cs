using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonProgAvancée
{
    class Pokemons
    {

        private string Nom { get; set; }
        private int Pv { get; set; }
        private int Puissance { get; set; }
        private string Type { get; set; }
        private string Faiblesse { get; set; }

        List<Pokemons> bddpokemon;

        string[,] types = new string[,] { { "Feu", "Eau" }, { "Terre", "Air" }, { "Eau", "Electricite" }, { "Air", "Plante" }, { "Plante", "Feu" }, { "Electricite", "Terre" } };

        List<string> nomspokemons = new List<string>("Bulbizarre", Herbizarre, Florizarre, Salamèche, Reptincel, Dracaufeu, Carapuce, Carabaffe, Tortank, Chenipan, Chrysacier, Papilusion, Aspicot, Coconfort, Dardargnan, Roucool, Roucoups, Roucarnage,
            Rattata, Rattatac, Piafabec, Rapasdepic, Abo, Arbok, Pikachu, Raichu, Sabelette, Sablaireau, Nidoran♀, Nidorina, Nidoqueen, Nidoran♂, Nidorino, Nidoking, Mélofée, Mélodelfe, Goupix, Feunard, Rondoudou, Grodoudou, Nosferapti, Nosferalto, Mystherbe, Ortide
            , Rafflésia, Paras, Parasect, Mimitoss);

        public Random alea = new Random();

        public Pokemons(string nom, int pv, int puissance, string type, string faiblesse)
        {
            Nom = nom;
            Pv = pv;
            Puissance = puissance;
            Type = type;
            Faiblesse = faiblesse;
        }

        private void creaBasePokemons ()
        {

        }
    }
}
