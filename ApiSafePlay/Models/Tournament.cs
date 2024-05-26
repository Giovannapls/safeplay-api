using System.ComponentModel.DataAnnotations.Schema;

namespace ApiSafePlay.Models
{
    public class Tournament
    {
        public int Id { get; set; }
        public List<int> ParticipantIds { get; set; } = new List<int>(); // List of participant user IDs
        public string Description { get; set; }
        public byte[] Icon { get; set; } // BLOB data for storing the tournament icon
        public Game Game { get; set; } // Associated game details
        public double Premiation { get; set; } // Prize money for the tournament

        [NotMapped]
        public List<User> Participants { get; set; } = new List<User>(); // List to hold participant details, not mapped to database

        public DateTime StartDate { get; set; } // Start date of the tournament
        public DateTime EndDate { get; set; } // End date of the  tournament
        public TournamentStatus Status { get; set; } // Current status of the tournament
    }

    public enum TournamentStatus
    {
        Planned, // Tournament is planned and has not yet started
        Active,  // Tournament is currently active
        Completed, // Tournament has ended
        Cancelled // Tournament was cancelled
    }
}
