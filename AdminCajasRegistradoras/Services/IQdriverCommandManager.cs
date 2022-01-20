using AdminCajasRegistradoras.Enums;
using AdminCajasRegistradoras.Models;

namespace AdminCajasRegistradoras.Services
{
    public interface IQdriverCommandManager
    {
        Task<string> GenerateDownloadCommandsAsync(Configuracion configuracion, Caja caja, EnumQdriverDownloadCommand downloadCommand);
    }
}
