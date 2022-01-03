using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPages.Filmes.WebApp.Models
{
    public class Movie
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [MaxLength(100, ErrorMessage = "You can't save a Movie without his title.")]
        public string Title { get; set; } = string.Empty;


        [DataType(DataType.Date)]
        [Display(Name = "Launch date")]
        public DateTime Launch_Date { get; set; }

        [Required(ErrorMessage = "You can't save a Movie without his category.")]
        [DataType(DataType.Text)]
        [MaxLength(100)]
        public string Category { get; set; } = string.Empty;

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Range(0,5)]
        public int Points { get; set; }

    }
}
