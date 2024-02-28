using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_DoLago.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        [Required(ErrorMessage = "Sorry, You need to enter a title")]
        public string Title { get; set; }

        [Range(1888, 2024, ErrorMessage = "You must enter a valid year")]
        public int Year { get; set; }
        
        public string? Director { get; set; }

        public string? Rating { get; set; }

        [Required(ErrorMessage = "Sorry, You need to enter a valid answer for Edited")]
        public bool Edited { get; set; }
        public string? LentTo { get; set; }

        [Required(ErrorMessage = "Sorry, You need to enter a valid answer for Copied To Plex")]
        public int CopiedToPlex { get; set; }
        public string? Notes { get; set; }

    }
}
