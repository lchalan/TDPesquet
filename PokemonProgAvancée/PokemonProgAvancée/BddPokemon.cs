using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonProgAvancée
{
    class BddPokemon
    {
        public Random alea = new Random();

        List<Pokemons> bddpokemon = new List<Pokemons> { };

        string[,] types = new string[,] { { "Feu", "Eau" }, { "Terre", "Air" }, { "Eau", "Electricite" }, { "Air", "Plante" }, { "Plante", "Feu" }, { "Electricite", "Terre" } };

        List<string> nomspokemons = new List<string> {"Bulbizarre", "Herbizarre", "Florizarre", "Salamèche", "Reptincel", "Dracaufeu", "Carapuce", "Racaillou", "Tortank", "Chenipan", "Chrysacier", "Papilusion", "Aspicot", "Coconfort", "Dardargnan", "Roucool","Mewtwo", "Ronflex",
            "Rattata", "Cabuto", "Piafabec", "Grolem", "Tentacool", "Arbok", "Pikachu", "Leviator", "Sabelette", "Magiecarp", "Nidoran", "Scarabrute", "Mr mime", "Kangourex", "Rhinoferoce", "Smogo", "Mélofée", "Osselait", "Goupix", "Feunard", "Rondoudou", "Voltrob", "Nosferapti", "Soporifik", "Mystherbe", "Ortide"
            ,"Rafflésia", "Paras", "Onix", "Mimitoss" };

        public void creaBasePokemons()
        {
            for (int i = 0; i < 48; i++)
            {
                int pv = alea.Next(500, 1001);
                int puissance = alea.Next(300, 501);
                int nb = alea.Next(1, 7);
                string type = types[nb, 0];
                string faiblesse = types[nb, 1];
                Pokemons P = new Pokemons(nomspokemons[i], pv, puissance, type, faiblesse);
                bddpokemon.Add(P);
            }
        }

        public override string ToString()
        {
            return "Les pokémons disponnibles sont :"+bddpokemon;
        }
    }
}
