namespace ApiSafePlay.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public string Biography { get; set; }
        public List<Category> Categories { get; set; } = new List<Category>();
        public List<Game> Games { get; set; } = new List<Game>();
        public double TimePlayed { get; set; }
        public int MatchesPlayed { get; set; }
        public int Tournaments { get; set; }
        public Game FavoriteGame { get; set; }

        public List<Achivement> Achivements { get; set; } = new List<Achivement>();
    }
}
