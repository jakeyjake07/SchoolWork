
namespace PokemonProperties;

class Program
{
    static void Main(string[] args)
    {
        Pokemon p = new Pokemon("Pikachu", 1, 100);

        Trainer trainer = new Trainer("Ash");


        trainer.AddPokemon(p);
        trainer.ShowTeam();


    }
}
