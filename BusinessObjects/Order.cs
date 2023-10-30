using System;
using System.Collections.Generic;

namespace BusinessObjects
{
    public partial class Order
    {
        public Order()
        {
            Payments = new HashSet<Payment>();
        }

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int ServiceId { get; set; }
        public double? Price { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Service Service { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
