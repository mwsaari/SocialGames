namespace SocialGames.Models
{
    public interface IGame
    {
        public string Name { get; }
        public string Description { get; }
        public int MinPlayers { get; }
        public int MaxPlayers { get; }
    }
}
