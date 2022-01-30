using System.Collections.Generic;

namespace Task1___LINQ.Extensions
{
    public static class LinqExtensions
    {
        public static string Join(this IEnumerable<string> enumerable)
        {
            return string.Join("", enumerable);
        }
    }
}