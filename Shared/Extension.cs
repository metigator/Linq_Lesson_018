using System;
using System.Collections.Generic;

namespace Shared
{
    public static class Extension
    {
        public static void Process<T>(this IEnumerable<T> source, string title) where T : Shipping
        {
            Console.WriteLine("┌───────────────────────────────────────────────────────┐");
            Console.WriteLine($"│   {title.PadRight(52, ' ')}│");
            Console.WriteLine("└───────────────────────────────────────────────────────┘");
            foreach (var item in source)
            {
                ((Shipping)item).Start();
            }
        }
    }
}
