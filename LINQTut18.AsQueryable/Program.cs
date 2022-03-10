using Shared;
using System;
using System.Linq;

namespace LINQTut18.AsQueryable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShippingList<Shipping> shippings = ShippingRepository.AllAsShippingList;

            var todayShipping = shippings.Where(x => x.ShippingDate == DateTime.Today);
            //Console.WriteLine(todayShipping.Expression); // not available for IEnumerable
            todayShipping.Process("Today's shipping using ShippingList<T> Where");


            IQueryable<Shipping> todayShipping2 = shippings.AsQueryable().Where(x => x.ShippingDate == DateTime.Today);

            todayShipping2.Process("Today's shipping using IQueryable<T> Where");


            Console.WriteLine(todayShipping2.Expression);
            Console.ReadKey();
        }
    }
}
