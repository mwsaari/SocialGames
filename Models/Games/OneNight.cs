namespace SocialGames.Models.Games
{
    public class OneNight : IGame
    {
        public string Name => "One Night";
        public string Description => "A fast-paced social deduction game where players take on roles and try to deduce who among them is the werewolf, vampire, or other hidden roles within a single night.";
        public int MinPlayers => 3;
        public int MaxPlayers => 10;
    }
}
