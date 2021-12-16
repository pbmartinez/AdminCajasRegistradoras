using System.ComponentModel.DataAnnotations;

namespace AdminCajasRegistradoras.Models
{
    public class ConfiguracionEncabezado
    {
        [Key]
        public Guid Id { get; set; }

        public string Nombre { get; set; }
        public const string NombreName = "Nombre";

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

        public int? Puerto { get; set; }
        public const string PuertoName = "PORT";

        public const string IpName = "IP";

        public bool Activa { get; set; }
        public const string ActivaName = "Activa";

        public ConfiguracionEncabezado()
        {
            Id = Guid.Empty;
            ClearLog = 0;
            EndFile = 0;
            Abort = 0;
            Result = 0;
            BaudRate = null;
            Puerto = null;
            Activa = false;
        }
    }
}
