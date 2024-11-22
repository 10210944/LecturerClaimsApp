using System.ComponentModel.DataAnnotations;

namespace LecturerClaimsApp.Models
{
    public class SupportingDocument
    {
        public int Id { get; set; }
        public int ClaimId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
    }
}
