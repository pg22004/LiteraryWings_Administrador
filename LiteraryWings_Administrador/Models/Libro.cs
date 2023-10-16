using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LiteraryWings_Administrador.Models
{
    public class Libro
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El Autor es obligatorio")]
        public int IdAutor { get; set; }

        [Required(ErrorMessage = "La Categoria es obligatoria")]
        public int IdCategoria { get; set; }

        [Required(ErrorMessage = "El Editorial es obligatorio")]
        public int IdEditorial { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La Fecha de Lanzamiento es obligatoria")]
        public string FechaLanzamiento { get; set; }

        [Required(ErrorMessage = "El Idioma es obligatorio")]
        public string Idioma { get; set; }

        [Required(ErrorMessage = "Las Paginas es obligatoria")]
        public int Paginas { get; set; }

        [Required(ErrorMessage = "La Descripcion es obligatoria")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "La Descripcion 2 es obligatoria")]
        public string Descripcion2 { get; set; }

        [Required(ErrorMessage = "La Imagen de Portada es obligatoria")]
        public string ImagenPortada { get; set; }

        [Required(ErrorMessage = "El Link de Descarga es obligatorio")]
        public string LinkDescarga { get; set; }

        [Required(ErrorMessage = "La Imagen de Introduccion es obligatoria")]
        public string ImagenIntroduccion { get; set; }


        public Autor Autor { get; set; }
        public Categoria Categoria { get; set; }
        public Editorial Editorial { get; set; }
    }
}
