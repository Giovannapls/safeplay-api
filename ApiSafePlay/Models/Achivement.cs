namespace ApiSafePlay.Models
{
    public class Achivement
    {
        public int Id { get; set; }
        public byte[] Icon { get; set; } // BLOB data for storing images or other binary data
        public string Description { get; set; }
    }
}
