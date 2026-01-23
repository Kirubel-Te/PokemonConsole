using PokemonPractical;

namespace PokemonPractical
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var logService = new PokemonLogService();
            var bulbasaur = new PokemonPractical("Bulbasaur");

            bulbasaur.LeveledUp += logService.Save;

            bulbasaur.GainExperience(5);
            bulbasaur.GainExperience(3);

            foreach (var entry in logService.GetAllEntries())
            {
                Console.WriteLine($"{entry.Name} leveled up by {entry.GainedLevels} levels.");
            }
        }
    }
}