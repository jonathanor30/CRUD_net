
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CRUD.Models.Entities
{
    public class CargoEmpleado
    {
        [Key]
        public int IdCargo { get; set; }


        [Column("Cargo", TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Cargo { get; set; }

    }
}

