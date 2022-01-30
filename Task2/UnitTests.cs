using System;
using FluentAssertions;
using NSubstitute;
using Task2.Providers;
using Xunit;

namespace Task2
{
    public class RozwiazanieTesty
    {
        private IDateTimeProvider _dateTimeProvider = Substitute.For<IDateTimeProvider>();
        private IFileProvider _fileProvider = Substitute.For<IFileProvider>();
        private TaskClass _taskClass;
        
        [Fact]
        public void DoWork_PositivePath_ReturnsTrue()
        {
            _taskClass = new TaskClass(_fileProvider, _dateTimeProvider);
            _fileProvider.ReadAllText("").Returns("good");
            _dateTimeProvider.Now.Returns(new DateTime(1990, 1, 1));
            
            bool result = _taskClass.DoWork();

            result.Should().BeTrue();
        }

        [Fact]
        public void DoWork_DataGoodDateBad_ReturnsFalse()
        {
            _taskClass = new TaskClass(_fileProvider, _dateTimeProvider);
            _fileProvider.ReadAllText("").Returns("good");
            _dateTimeProvider.Now.Returns(new DateTime(2022, 1, 1));
            
            bool result = _taskClass.DoWork();

            result.Should().BeFalse();
        }
        
        [Fact]
        public void DoWork_DataBadDateGood_ReturnsFalse()
        {
            _taskClass = new TaskClass(_fileProvider, _dateTimeProvider);
            _fileProvider.ReadAllText("").Returns("foobar");
            _dateTimeProvider.Now.Returns(new DateTime(1990, 1, 1));
            
            bool result = _taskClass.DoWork();

            result.Should().BeFalse();
        }
        
        [Fact]
        public void DoWork_DataBadDateBad_ReturnsFalse()
        {
            _taskClass = new TaskClass(_fileProvider, _dateTimeProvider);
            _fileProvider.ReadAllText("").Returns("foobar");
            _dateTimeProvider.Now.Returns(new DateTime(2022, 1, 1));
            
            bool result = _taskClass.DoWork();

            result.Should().BeFalse();
        }
    }
}