namespace Cypher.Models
{
    internal class Game
    {
        public GameType Type { get; set; }
        public int Score { get; set; }
        public DateTime Date { get; } = DateTime.UtcNow;
    }
}
