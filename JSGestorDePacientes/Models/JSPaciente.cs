using System.ComponentModel.DataAnnotations;

namespace JSGestorDePacientes.Models
{
    public class JSPaciente
    {
        [Key]
        public int JSIdPaciente { get; set; }

        [Required(ErrorMessage = "El Nombre es obligatorio")]
        public string JSNombre { get; set; }
        [Required(ErrorMessage = "El Apellido es obligatorio")]
        public string JSApellido { get; set; }
        [Required(ErrorMessage = "La descripcion de la enfermedad es obligatorio")]
        public string JSEnfermedad { get; set; }
        [RegularExpression(@"^\d{10}$", ErrorMessage = "El DNI debe tener exactamente 10 números.")]
        public string JSDNI { get; set; }

        [Required]

        public int JSIdCategoria { get; set; }
        public JSCategoria? JSCategoria { get; set; }
        public ICollection<JSCategoria> Categorias { get; set; }
    }
}
