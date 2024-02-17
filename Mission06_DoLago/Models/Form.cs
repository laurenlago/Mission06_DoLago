using System.ComponentModel.DataAnnotations;

namespace Mission06_DoLago.Models
{
    public class Form
    {
        [Key]
        [Required]
        public int FormID { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public bool Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }

        }
    }
