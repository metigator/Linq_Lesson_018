using System;
using System.Collections.Generic;
using System.Linq; 

namespace Shared
{
    public class ShippingList<T>: List<T> where T:Shipping
    {
        public IEnumerable<T> Where (Func<T, bool> predicate)
        {
            Console.WriteLine("filtering shipping ...");
            return Enumerable.Where(this, predicate);
        } 
    }
}
