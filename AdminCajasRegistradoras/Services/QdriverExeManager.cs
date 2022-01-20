using System.Diagnostics;

namespace AdminCajasRegistradoras.Services
{
    public class QdriverExeManager : IQdriverExeManager
    {
        public Task ExecuteQdriverAsync()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\qdriver");
            var info = new ProcessStartInfo
            {
                UseShellExecute = true,
                FileName = "qdriver.exe",
                WorkingDirectory = filePath,
                Arguments = "secuencia.cmd"
            };
            
            
            Process.Start(info); 
            return Task.CompletedTask;
        }
    }
}
