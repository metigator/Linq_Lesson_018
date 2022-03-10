using System.Collections.Generic;
using System.Linq; 
namespace LINQTut17.ExpressionTree04
{
    internal static class DatabaseSource
    {
        public static IQueryable<Customer> Customers => new List<Customer> {
                new Customer { Name = "Ali Salem", IsVip = true },
                new Customer { Name = "Reem Saleh", IsVip = true },
                new Customer { Name = "Ruba Ahmad", IsVip = false },
                new Customer { Name = "Ruba Ahmad", IsVip = false },
                new Customer { Name = "Ruba Ahmad", IsVip = false },
                new Customer { Name = "Ruba Ahmad", IsVip = false },
        }.AsQueryable();
    }
}
