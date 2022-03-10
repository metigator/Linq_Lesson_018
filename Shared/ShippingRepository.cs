using System;
using System.Collections.Generic;

namespace Shared
{
    public static class ShippingRepository
    {
        public static List<Shipping> AllAsList => new List<Shipping> {
            new GroundShipping("ABC001", "Issam Ab", DateTime.Today.AddDays(-1)),
            new AirShipping("ABC002", "Abeer Baker", DateTime.Today.AddDays(-1)),
            new OceanShipping("ABC003", "Samah Saleh", DateTime.Today.AddDays(-1)),
            new AirShipping("ABC004", "Ahmed Ali", DateTime.Today.AddDays(-1)),
            new GroundShipping("ABC005", "Issam Ab", DateTime.Today),
            new AirShipping("ABC006", "Abeer Baker", DateTime.Today),
            new OceanShipping("ABC007", "Samah Saleh", DateTime.Today),
            new AirShipping("ABC008", "Ahmed Ali", DateTime.Today),
             new GroundShipping("ABC009", "Issam Ab", DateTime.Today.AddDays(1)),
            new AirShipping("ABC010", "Abeer Baker", DateTime.Today.AddDays(1)),
            new OceanShipping("ABC011", "Samah Saleh", DateTime.Today.AddDays(1)),
            new AirShipping("ABC012", "Ahmed Ali", DateTime.Today.AddDays(1))
        };

        public static ShippingList<Shipping> AllAsShippingList => new ShippingList<Shipping>
        {
            new GroundShipping("ABC001", "Issam Ab", DateTime.Today.AddDays(-1)),
            new AirShipping("ABC002", "Abeer Baker", DateTime.Today.AddDays(-1)),
            new OceanShipping("ABC003", "Samah Saleh", DateTime.Today.AddDays(-1)),
            new AirShipping("ABC004", "Ahmed Ali", DateTime.Today.AddDays(-1)),
            new GroundShipping("ABC005", "Issam Ab", DateTime.Today),
            new AirShipping("ABC006", "Abeer Baker", DateTime.Today),
            new OceanShipping("ABC007", "Samah Saleh", DateTime.Today),
            new AirShipping("ABC008", "Ahmed Ali", DateTime.Today),
            new GroundShipping("ABC009", "Issam Ab", DateTime.Today.AddDays(1)),
            new AirShipping("ABC010", "Abeer Baker", DateTime.Today.AddDays(1)),
            new OceanShipping("ABC011", "Samah Saleh", DateTime.Today.AddDays(1)),
            new AirShipping("ABC012", "Ahmed Ali", DateTime.Today.AddDays(-1))
        };

     
    }
}
