using System.ComponentModel.DataAnnotations;

namespace LiteraryWings_Administrador.Models
{
    public class Sugerencia
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El correo es requerido")]
        public string Correo { get; set; }
        [Required(ErrorMessage = "El comentario es requerido")]
        public string Comentario { get; set; }
    }
}
