using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace AdminCajasRegistradoras.Services
{
    public class FileManager : IFileManager
    {
        public async Task GenerateCommandsFileAsync(string commands)
        {
            var fileName = "secuencia.cmd";
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\qdriver", fileName);

            using StreamWriter file = new(filePath, append: false);
            await file.WriteLineAsync(commands);            
        }

        public async Task GenerateCommandsFileAsync(string[] commands)
        {
            var fileName = "secuencia.cmd";
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\qdriver", fileName);

            using StreamWriter file = new(filePath, append: false);
            foreach (var command in commands)
                await file.WriteLineAsync(command);
        }

        //public IActionResult Download()
        //{
        //    var fileName = "secuencia.cmd";
        //    var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\qdriver", fileName);

        //    byte[] fileBytes = GetFile(filePath);
            
        //    return new File(
        //        fileBytes);
        //}

        private byte[] GetFile(string s)
        {
            System.IO.FileStream fs = System.IO.File.OpenRead(s);
            byte[] data = new byte[fs.Length];
            int br = fs.Read(data, 0, data.Length);
            if (br != fs.Length)
                throw new System.IO.IOException(s);
            return data;
        }
    }
}
