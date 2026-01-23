namespace PokemonPractical
{
    public class PokemonLogService
    {
        private List<PokemonLogEntry> logEntries = new List<PokemonLogEntry>();

        public void Save(string name, int gainedLevels)
        {
            var entry = new PokemonLogEntry(name, gainedLevels);
            logEntries.Add(entry);
        }
        public List<PokemonLogEntry> GetAllEntries()
        {
            return logEntries;
        }
    }
}