namespace PokemonPractical
{
    public class PokemonRepository
    {
        private List<PokemonPractical> pokemons = new List<PokemonPractical>();
        public void AddPokemon(PokemonPractical pokemon)
        {
            pokemons.Add(pokemon);
        }
        public PokemonPractical GetByName(string name)
        {
            return pokemons.FirstOrDefault(p => p.Name == name);
        }

        public List<PokemonPractical> GetAllPokemons()
        {
            return pokemons;
        }
    }
}