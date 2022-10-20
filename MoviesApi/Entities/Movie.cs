using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesApi.Entities
{
    public class Movie
    {
        public int Id { get; set; }

        [MaxLength(250)]

        public string Title { get; set; }=String.Empty;

        public int Year { get; set; }

        public double Rate { get; set; }

        [MaxLength(2500)]
        public string Storeline { get; set; } = String.Empty;

        public byte[] Poster { get; set; }

        public int GenreId { get; set; }
        [ForeignKey("GenreId")]
        public Genre Genre { get; set; } 
    }
}
