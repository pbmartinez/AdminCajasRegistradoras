using AdminCajasRegistradoras.Enums;
using AdminCajasRegistradoras.Models;

namespace AdminCajasRegistradoras.Services
{
    public class QdriverCommandManager : IQdriverCommandManager
    {
        public Task<string> GenerateDownloadCommandsAsync(Configuracion configuracion, Caja caja, EnumQdriverDownloadCommand downloadCommand)
        {
            var header = configuracion.Header;
            var registerValue = caja.Register == 0 ? "0" : "1";
            var register = $"REGISTER={registerValue}";

            var conexionCaja = string.IsNullOrEmpty(caja.Ip) || string.IsNullOrWhiteSpace(caja.Ip)
            ? $"PORT={caja.Puerto}"
            : $"IP={caja.Ip}\nPORT={caja.Puerto}";

            var ficheroSalida = $"NEWFILE=salida.txt";
            var download = $"COMMAND={downloadCommand}";

            var comandos = $"{header}\n{register}\n{conexionCaja}\n{ficheroSalida}\n{download}";

            return Task.FromResult(comandos);
        }
    }
}
