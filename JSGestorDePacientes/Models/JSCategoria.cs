using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel.DataAnnotations;

namespace JSGestorDePacientes.Models
{
    public class JSCategoria
    {
        [Key]
        public int JSIdCategoria { get; set; }

        [Required(ErrorMessage = "Debe ingresarla gravedad")]
        public string JSGravedad { get; set; }


        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime JSFechaIngreso { get; set; }

    }
}
