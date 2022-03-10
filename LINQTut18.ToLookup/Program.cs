using Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQTut18.ToLookup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Shipping> shippings = ShippingRepository.AllAsList;

            ILookup<string, Shipping> lookup1 = shippings.ToLookup(x => x.UniqueId);
            lookup1["ABC005"].First().Start();

            ILookup<DateTime, Shipping> lookup2 = shippings.ToLookup(x => x.ShippingDate);
                
            var date = new DateTime(2022, 3, 9, 0, 0, 0);
            lookup2[date].Process($"Shippings on {date.ToString("dddd, MMMM dd yyyy")}");
            Console.ReadKey();
        }
    } 
}
