using System.ComponentModel.DataAnnotations;

namespace MoviesApi.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }=String.Empty;
    }
}
