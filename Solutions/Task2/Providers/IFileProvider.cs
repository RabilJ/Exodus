namespace Task2.Providers
{
    public interface IFileProvider
    {
        public string ReadAllText(string path);
    }
}