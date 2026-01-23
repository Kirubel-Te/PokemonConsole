namespace PokemonPractical
{
    public class PokemonPractical
    {
        public string Name { get; set; } = null!;
        public int Level { get; set; }

        
        public PokemonPractical(string name)
        {
            Name = name;
            Level = 1;
        }
        public event Action<string,int> LeveledUp;

        public void GainExperience(int gain)
        {
            Level += gain;

            LeveledUp?.Invoke(Name, gain);
        }
    }
}