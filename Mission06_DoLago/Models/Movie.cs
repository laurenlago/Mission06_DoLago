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
        public Category Category { get; set; }
        public string Title { get; set; }
        [Required(ErrorMessage = "Sorry, You need to enter a title")]
        public int Year { get; set; }
        [Range(1888, 2024, ErrorMessage = "You must enter a valid year")]

        public string Director { get; set; }

        public bool Rating { get; set; }
        public bool Edited { get; set; }
        [Required(ErrorMessage = "Sorry, You need to enter a valid answer for Edited")]
        public string LentTo { get; set; }
        public int CopiedToPlex { get; set; }
        [Required(ErrorMessage = "Sorry, You need to enter a valid answer for Copied To Plex")]
        public string Notes { get; set; }

    }
}
