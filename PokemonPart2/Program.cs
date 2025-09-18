namespace PokemonPart2;

class Program
{
    static void Main(string[] args)
    {

        FirePokemon f1 = new FirePokemon("Charmander", 1, 100);
        ElectricPokemon e1 = new ElectricPokemon("Pikachu", 1, 100);

        f1.Info();
        f1.Attack();

        e1.Info();
        e1.Attack();

        List<Pokemon> pokemonList = new List<Pokemon>();
        

    }
}
