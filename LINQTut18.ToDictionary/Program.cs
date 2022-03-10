using Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQTut18.ToDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Shipping> shippings = ShippingRepository.AllAsList;
           
            Dictionary<string, Shipping> dictionary1 = shippings.ToDictionary(x => x.UniqueId);
            dictionary1["ABC005"].Start();

            Dictionary<DateTime, List<Shipping>> dictionary2 = shippings.GroupBy(x => x.ShippingDate)
                .ToDictionary(s => s.Key, s => s.ToList());
            var date = new DateTime(2022, 3, 9, 0, 0, 0);
            dictionary2[date].Process($"Shippings on {date.ToString("dddd, MMMM dd yyyy")}");
            Console.ReadKey();
        }
    }
}
