using Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQTut18.ToArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Shipping> shippings = ShippingRepository.AllAsList;
            var shippingArray = shippings.ToArray();
            Console.WriteLine($"total shippings: {shippingArray.Length}");
            Console.WriteLine($"first shipping");
            shippingArray[0].Start();
            Console.ReadKey();
        }
    }
}
