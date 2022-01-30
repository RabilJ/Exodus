using System;
using System.IO;

namespace Task2___DI
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
        public bool DoWork()
        {
            string data = GetData();
           
            return data.Equals("good") && DateTime.Now.Year < 2020;
        }

        public string GetData()
        {
            return File.ReadAllText("");;
        } 
    }
}