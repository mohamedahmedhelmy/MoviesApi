using System.ComponentModel.DataAnnotations;

namespace MoviesApi.DTOs
{
    public class GenreDto
    {
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
