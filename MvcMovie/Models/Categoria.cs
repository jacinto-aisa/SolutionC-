using MvcMovie.Controllers;

namespace MvcMovie.Models
{
    public class Categoria
    {
        public Categoria(ICollection<Movie> movies)
        {
            Movies = movies;
        }

        public int Id { get; set; }
        public string? Nome { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
