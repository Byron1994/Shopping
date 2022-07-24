using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class Country
    {

        public int Id { get; set; }
        [Required(ErrorMessage ="El campo {0} es obligatorio.")]
        [MaxLength(50,ErrorMessage ="El campo {0} debe tener maximo {1} caracteres.")]
        [Display(Name="Pais")]
        public string Name { get; set; }

    }
}
