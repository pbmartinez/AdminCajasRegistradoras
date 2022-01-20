namespace AdminCajasRegistradoras.Services
{
    public interface IFileManager
    {
        public Task GenerateCommandsFileAsync(string commands);
        public Task GenerateCommandsFileAsync(string[] commands);
    }
}
