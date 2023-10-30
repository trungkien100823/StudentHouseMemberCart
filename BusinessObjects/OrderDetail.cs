using System;
using System.Collections.Generic;

namespace BusinessObjects
{
    public partial class OrderDetail
    {
        public int? OrderId { get; set; }
        public int? ServiceId { get; set; }
        public string ServiceName { get; set; }
        public double? Price { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Address { get; set; }
        public string PaymentMethod { get; set; }

        public virtual Order Order { get; set; }
        public virtual Service Service { get; set; }
    }
}
