using System;

namespace Task2.Providers
{
    public interface IDateTimeProvider
    {
        public DateTime Now { get; }
    }
}