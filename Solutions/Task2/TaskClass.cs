using Task2.Providers;

namespace Task2
{
    /*
     * Test all paths of DoWork method(using nUnit)
     * Use dependency inversion/injection
     * Create proper files and directories as needed
     * You are allowed to change this file but not the logic of it
     * That means that running this code should return the same result
     */
    
    public class TaskClass
    {
        private IFileProvider _fileProvider;
        private IDateTimeProvider _dateTimeProvider;
        
        public TaskClass(IFileProvider fileProvider, IDateTimeProvider dateTimeProvider)
        {
            _fileProvider = fileProvider;
            _dateTimeProvider = dateTimeProvider;
        }
        
        public bool DoWork()
        {
            string data = GetData();
           
            return data.Equals("good") && _dateTimeProvider.Now.Year < 2020;
        }

        public string GetData()
        {
            return _fileProvider.ReadAllText("");;
        }
    }
}