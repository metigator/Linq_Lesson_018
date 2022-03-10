using Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQTut18.ToList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Shipping> shippings = ShippingRepository.AllAsList;

            List<Shipping> shippingList = shippings.ToList();

            Console.WriteLine($"total shippings: {shippingList.Count}");
            Console.WriteLine($"first shipping");
            shippingList[0].Start();
            shippingList.First().Start();
            Console.ReadKey();
        }
    } 
}
