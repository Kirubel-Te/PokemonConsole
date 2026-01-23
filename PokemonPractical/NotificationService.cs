namespace PokemonPractical
{
    public class NotificationService
    {
        public void Announce(int amount)
        {
            System.Console.WriteLine($"A Pokemon has leveled up by {amount} levels!");
        }
    }
}