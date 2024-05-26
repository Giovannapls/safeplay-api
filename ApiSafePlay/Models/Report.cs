namespace ApiSafePlay.Models
{
    public class Report
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now; // Automatically sets to current time
        public DateTime IncidentTime { get; set; }
        public byte[] Attachments { get; set; } // BLOB data
        public string Description { get; set; }
    }
}
