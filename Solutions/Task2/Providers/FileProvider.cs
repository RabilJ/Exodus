using System.IO;

namespace Task2.Providers
{
    public class FileProvider : IFileProvider
    {
        public string ReadAllText(string path)
        {
            return File.ReadAllText(path);
        }
    }
}