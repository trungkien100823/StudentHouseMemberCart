using System;
using System.Collections.Generic;

namespace BusinessObjects
{
    public partial class AdminService
    {
        public int? AdminId { get; set; }
        public int? ServiceId { get; set; }
        public DateTime? LatestUpdate { get; set; }

        public virtual Admin Admin { get; set; }
        public virtual Service Service { get; set; }
    }
}
