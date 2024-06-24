using System.ComponentModel.DataAnnotations;

namespace WebAplicationMonica.Models
{
    public class Curso
    {
        public int Id { get; set; }
        [Display(Name="Nombre")]
        public string? Name { get; set; }    
        public virtual List<Modulo>? Modulos { get; set; }

    }
}
