namespace LecturerClaimsApp.Models
{
    public class LecturerClaim
    {
        public int ClaimId { get; set; } // Unique identifier for each claim
        public string LecturerName { get; set; }
        public int HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
        public decimal TotalAmount => HoursWorked * HourlyRate;
        public string RejectionReason { get; set; }
        public string AdditionalNotes { get; set; }
        public string DocumentPath { get; set; } // Optional document path for attached files
        public string Status { get; set; } = "Pending"; // Default status is "Pending"
    }
}
