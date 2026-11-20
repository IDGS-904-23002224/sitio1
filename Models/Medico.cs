using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sitio1.Models
{
    [Table("Medicos")]
    public class Medico
    {
        [Key]
        [Column("idMedico")]
        public int IdMedico { get; set; }

        [Column("Nombre")]
        public string Nombre { get; set; } = string.Empty;

        [Column("APaterno")]
        public string APaterno { get; set; } = string.Empty;

        [Column("AMaterno")]
        public string? AMaterno { get; set; }

        [Column("Telefono")]
        public string? Telefono { get; set; }

        [Column("Direccion")]
        public string? Direccion { get; set; }

        [Column("Especialidad")]
        public string? Especialidad { get; set; }

        [Column("Estatus")]
        public bool Estatus { get; set; } = true;
    }
}
