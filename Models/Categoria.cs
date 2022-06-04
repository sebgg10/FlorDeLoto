using System.ComponentModel.DataAnnotations;
namespace FlorDeLoto.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="Nombre de la categoria")]
        public string Nombre { get; set; }
    }
}