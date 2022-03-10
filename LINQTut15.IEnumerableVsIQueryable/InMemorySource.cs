using System.Collections.Generic;

namespace LINQTut17.ExpressionTree04
{
    internal static class InMemorySource
    {
        public static IEnumerable<Customer> Customers => new List<Customer> {
                new Customer { Name = "Ali Salem", IsVip = true },
                new Customer { Name = "Reem Saleh", IsVip = true },
                new Customer { Name = "Ruba Ahmad", IsVip = false },
                new Customer { Name = "Salah Sami", IsVip = false },
                new Customer { Name = "Jalal Ahmad", IsVip = false },
                new Customer { Name = "Sultan Abed", IsVip = false },
        };
    }
}
