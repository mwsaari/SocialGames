namespace SocialGames.Models.Games
{
    public class SecretSocieties : IGame
    {
        public string Name => "Secret Societies";
        public string Description => "A game of hidden identities and secret missions, where players form secret societies to achieve their goals while keeping their true intentions hidden from others.";
        public int MinPlayers => 4;
        public int MaxPlayers => 7;
    }
}