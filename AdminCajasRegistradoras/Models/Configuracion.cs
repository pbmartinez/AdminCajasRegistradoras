using System.ComponentModel.DataAnnotations;

namespace AdminCajasRegistradoras.Models
{
    public class Configuracion
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Header { get; set; } = string.Empty;
        public const string HeaderName = "Header";

        public bool Activa { get; set; }
        public const string ActivaName = "Activa";
    }
}
