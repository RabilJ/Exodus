using System;
using System.Collections.Generic;

namespace Task1___LINQ
{
    public class TaskClass
    {
        #region Example data

        private List<Data> exampleTaskA = new()
        {
            new Data() {Number = 5, Char = "abc"},
            new Data() {Number = 2, Char = "efg"},
            new Data() {Number = 11, Char = "hij"},
            new Data() {Number = 6, Char = "klm"},
            new Data() {Number = 7, Char = "nop"}
        };
        
        private string loremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit";
        
        private int[] exampleTaskD = { 5, 6, 8, 2, 45, 7, 4, 35, 5, 42, 4234, 23, 47, 10, 3, 12 };

        private string[] exampleTaskE = { "saidfg", "fsdh", "fsddj", "agdhx", "gjhrt", "aweex", "hjkds"};
        
        private  List<Data> exampleTaskF = new()
        {
            new Data() {Number = 12, Char = "abc"},
            new Data() {Number = 2, Char = "efg"},
            new Data() {Number = 11, Char = "ba"},
            new Data() {Number = 6, Char = "klm"},
            new Data() {Number = 7, Char = "nan"}
        };
        
        #endregion
        
        // Find all objects where Number is bigger than 5
        // use data from exampleTaskA
        public List<Data> TaskA()
        {
            return null;
        }
        
        // count number of words
        // use data from loremIpsum
        public int TaskB()
        {
            return Int32.MaxValue;
        }
        
        // Create list of Data that contains number of occurrence of every letter
        // e.g. Data { Number = 5, Char = "a" }
        // use data from loremIpsum
        public List<Data> TaskC()
        {
            return null;
        }
        
        // return only even numbers
        // use data from exampeTaskD
        public int[] TaskD()
        {
            return null;
        }
        
        // return only words that start with letter A and end with letter X
        // use data from exampleTaskE
        public IEnumerable<string> TaskE()
        {
            return null;
        }
        
        // create string from list of Data objects(their Char field), for which Number is odd
        // finish extension for Join method for LINQ that joins all the strings in the list into one single string
        // e.g. select().join() on { "a", "b" } should return "ab"
        // use data from exampleTaskF
        public string TaskF()
        {
            return string.Empty;
        }
    }
}