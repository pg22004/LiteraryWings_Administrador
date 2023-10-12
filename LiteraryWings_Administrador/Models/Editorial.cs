using System.ComponentModel.DataAnnotations;

namespace LiteraryWings_Administrador.Models
{
    public class Editorial
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }

    }
}

