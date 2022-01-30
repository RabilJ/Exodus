using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Task1___LINQ
{
    public class UnitTest1
    {
        private static List<Data> taskASolution = new List<Data>()
        {
            new() { Number = 11, Char = "hij" },
            new() { Number = 6, Char = "klm" },
            new() { Number = 7, Char = "nop" }
        };

        private static int taskBSolution = 8;
        
        private static List<Data> taskCSolution = new List<Data>
        {
            new() { Number = 1, Char = "L" },
            new() { Number = 4, Char = "o" },
            new() { Number = 3, Char = "r" },
            new() { Number = 5, Char = "e" },
            new() { Number = 3, Char = "m" },
            new() { Number = 7, Char = " " },
            new() { Number = 6, Char = "i" },
            new() { Number = 2, Char = "p" },
            new() { Number = 4, Char = "s" },
            new() { Number = 2, Char = "u" },
            new() { Number = 2, Char = "d" },
            new() { Number = 2, Char = "l" },
            new() { Number = 5, Char = "t" },
            new() { Number = 2, Char = "a" },
            new() { Number = 1, Char = "," },
            new() { Number = 3, Char = "c" },
            new() { Number = 2, Char = "n" },
            new() { Number = 1, Char = "g" }
        };
        
        private static int[] taskDSolution = { 6, 8, 2, 4, 42, 4234, 10, 12 };
        
        private static IEnumerable<string> taskESolution = new[] {"agdhx", "aweex" };

        private static string taskFSolution = "banan";

        private TaskClass tasks = new TaskClass();
        
        [Fact]
        public void VerifyTaskA()
        {
            tasks.TaskA().Should().BeEquivalentTo(taskASolution);
        }
        
        [Fact]
        public void VerifyTaskB()
        {
            tasks.TaskB().Should().Be(taskBSolution);
        }
        
        [Fact]
        public void VerifyTaskC()
        {
            tasks.TaskC().Should().BeEquivalentTo(taskCSolution);
        }
        
        [Fact]
        public void VerifyTaskD()
        {
            tasks.TaskD().Should().BeEquivalentTo(taskDSolution);
        }
        
        [Fact]
        public void VerifyTaskE()
        {
            tasks.TaskE().Should().BeEquivalentTo(taskESolution);
        }
        
        [Fact]
        public void VerifyTaskF()
        {
            tasks.TaskF().Should().Be(taskFSolution);
        }
    }
}