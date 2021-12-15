using AdminCajasRegistradoras.DataAnnotations;
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
        [IpAddress(ErrorMessage = "La dirección ip no es válida")]
        public string Ip { get; set; } = string.Empty;

        [Required]
        [Range(1,99999)]
        public int Puerto { get; set; }

        public Caja()
        {
            Id = Guid.Empty;
            Nombre = string.Empty;
            Numero = 0;
            Ip = string.Empty;
        }

        public Caja(Guid id, string nombre, int numero, string ip)
        {
            Id = id;
            Nombre = nombre;
            Numero = numero;
            Ip = ip;
        }
    }
}
