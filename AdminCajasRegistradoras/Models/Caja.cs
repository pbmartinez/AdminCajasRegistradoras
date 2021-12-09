using System.ComponentModel.DataAnnotations;

namespace AdminCajasRegistradoras.Models
{
    public class Caja
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Nombre { get; set; } = string.Empty;

        public int Numero { get; set; }

        [Required]
        public string Ip { get; set; } = string.Empty;

    }
}
