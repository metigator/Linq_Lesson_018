using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQTut17.ExpressionTree04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Customer> customersInMemory = InMemorySource.Customers;

            IQueryable<Customer> cutomersInDatabase = DatabaseSource.Customers;
            Queryable
            Console.ReadKey();
        }
    }
}
