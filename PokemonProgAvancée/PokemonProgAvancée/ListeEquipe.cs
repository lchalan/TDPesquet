using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonProgAvancée
{
    class ListeEquipe
    {
        public Random alea = new Random();

        List<Equipe> equipe = new List<Equipe> { };

        List<Pokemons> bddpokemon2 = new List<Pokemons> { };

        //List<string> nomspokemons = new List<string> {"Bulbizarre", "Herbizarre", "Florizarre", "Salamèche", "Reptincel", "Dracaufeu", "Carapuce", "Racaillou", "Tortank", "Chenipan", "Chrysacier", "Papilusion", "Aspicot", "Coconfort", "Dardargnan", "Roucool","Mewtwo", "Ronflex",
        //    "Rattata", "Cabuto", "Piafabec", "Grolem", "Tentacool", "Arbok", "Pikachu", "Leviator", "Sabelette", "Magiecarp", "Nidoran", "Scarabrute", "Mr mime", "Kangourex", "Rhinoferoce", "Smogo", "Mélofée", "Osselait", "Goupix", "Feunard", "Rondoudou", "Voltrob", "Nosferapti", "Soporifik", "Mystherbe", "Ortide"
        //    ,"Rafflésia", "Paras", "Onix", "Mimitoss" };


        List<string> noms = new List<string> { "Red", "Leaf", "Ludwig", "Ludvina", "Kalem", "Serena", "Florent", "Scout", "Silver", "Trovato", "Giovanni", "Lysandre", "Maladif", "Pierre", "Lem" };

        public void creaEquipe()
        {
            BddPokemon pokemonsdispo = new BddPokemon();
            pokemonsdispo.creaBasePokemons();
            bddpokemon2 = pokemonsdispo.bddpokemon;
            for (int i = 0; i < 16; i++)
            {
                string nomequipe = noms[i];
                int nb1 = alea.Next(0, 47-i*3);
                int nb2 = alea.Next(0, 47 - i * 3);
                int nb3 = alea.Next(0, 47 - i * 3);
                Pokemons p1 = bddpokemon2[nb1];
                Console.WriteLine(p1);
                Pokemons p2 = bddpokemon2[nb2];
                Pokemons p3 = bddpokemon2[nb3];
                //Equipe equipe = new Equipe(nomequipe, p1, p2, p3);

                //delete les 3 poké de la liste des pokémons
                bddpokemon2.Remove(p1);
                bddpokemon2.Remove(p2);
                bddpokemon2.Remove(p3);
            }
        }
        public override string ToString()
        {
            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine("Nom du dresseur : "+equipe[i].NomEquipe+ ", Pokémon 1 : "+equipe[i].Pokémon1+ ", Pokémon 2 : " + equipe[i].Pokémon2+ ", Pokémon 3 : " + equipe[i].Pokémon3);
            }
            return "";
        }
    }
}
