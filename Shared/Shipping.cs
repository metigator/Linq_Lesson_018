using System;

namespace Shared
{
    public abstract class Shipping
    { 
        protected Shipping(string uniqueId, string sender, DateTime shippingDate)
        {
            this.UniqueId = uniqueId;
            this.Sender = sender;
            this.ShippingDate = shippingDate;
        }
        public string UniqueId { get; private set; }
        public string Sender { get; private set; }
        public DateTime ShippingDate { get; private set; }
        public abstract string Description { get; }
        public virtual void Start()
        {
            Console.WriteLine(
             $"\n\tCode: {UniqueId}" +
             $"\n\tDescription {Description}" +
             $"\n\tSender: {Sender}" +
             $"\n\tDate: {ShippingDate.ToShortDateString()}"
             );
        }
    }

    public class AirShipping : Shipping
    {
        public AirShipping(string uniqueId, string sender, DateTime shippingDate) :base(uniqueId, sender, shippingDate)
        { 
        }
        public override string Description => "Air shipping";
         
    }

    public class GroundShipping : Shipping
    {
        public GroundShipping(string uniqueId, string sender, DateTime shippingDate) : base(uniqueId, sender, shippingDate)
        {
        }
        public override string Description => "Ground Shipping";
         
    }


    public class OceanShipping : Shipping
    {
        public OceanShipping(string uniqueId, string sender, DateTime shippingDate) : base(uniqueId, sender, shippingDate)
        {
        }
        public override string Description => "Ocean Shipping";
 
    }

    public class RailShipping : Shipping
    {
        public RailShipping(string uniqueId, string sender, DateTime shippingDate) : base(uniqueId, sender, shippingDate)
        {
        }
        public override string Description => "Rail Shipping";
 
    }
}
