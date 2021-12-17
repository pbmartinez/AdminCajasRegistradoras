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
        public const string NombreName = "Nombre";

        public int? Numero { get; set; }
        public const string NumeroName = "Numero";

        [IpAddress(ErrorMessage = "La dirección ip no es válida")]
        public string? Ip { get; set; } = string.Empty;
        public const string IpName = "Direccion Ip";

        [Range(1,99999)]
        public int? Puerto { get; set; }
        public const string PuertoName = "Puerto";

        public int Visible { get; set; }
        public const string VisibleName = "VISIBLE";

        public int ClearLog { get; set; }
        public const string ClearLogName = "CLEARLOG";

        public int EndFile { get; set; }
        public const string EndFileName = "ENDFILE";

        public int Abort { get; set; }
        public const string AbortName = "ABORT";

        public int Result { get; set; }
        public const string ResultName = "RESULT";

        public int? BaudRate { get; set; }
        public const string BaudRateName = "BAUDRATE";

        public Caja()
        {
            Id = Guid.Empty;
            Nombre = string.Empty;
            Numero = 0;
            Ip = string.Empty;
            Puerto = null;

            Visible = 1;
            ClearLog = 1;
            EndFile = 1;
            Abort = 1;
            Result = 1;
            BaudRate = null;
        }

        public Caja(Guid id,
                    string nombre,
                    int? numero,
                    string? ip,
                    int? puerto,
                    int visible,
                    int clearLog,
                    int endFile,
                    int abort,
                    int result,
                    int? baudRate)
        {
            Id = id;
            Nombre = nombre;
            Numero = numero;
            Ip = ip;
            Puerto = puerto;
            Visible = visible;
            ClearLog = clearLog;
            EndFile = endFile;
            Abort = abort;
            Result = result;
            BaudRate = baudRate;
        }
    }
}
