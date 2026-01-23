namespace PokemonPractical
{
    public class PokemonService
    {
        private PokemonRepository repository = new PokemonRepository();

        public void RegisterPokemon(string name)
        {
            var pokemon = new PokemonPractical(name);
            repository.AddPokemon(pokemon);
        }

        public void TrainPokemon(string name, int gain)
        {
            var pokemon = repository.GetByName(name);
            if (pokemon != null)
            {
                pokemon.GainExperience(gain);
            }
        }
        public List<PokemonPractical> GetAllPokemons()
        {
            return repository.GetAllPokemons();
        }
    }
}