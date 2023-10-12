using System.ComponentModel.DataAnnotations;

namespace LiteraryWings_Administrador.Models
{
    public class Autor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es requerido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es requerida")]
        public string FechaNacimiento { get; set; }

        [Required(ErrorMessage = "La  imagen es requerida")]
        public string AutorImagen { get; set; }

        [Required(ErrorMessage = "El seudonimo es requerido")]
        public string Seudonimo { get; set; }

        [Required(ErrorMessage = "La nacionalidad es requerida")]
        public string Nacionalidad { get; set; }
    }
}
