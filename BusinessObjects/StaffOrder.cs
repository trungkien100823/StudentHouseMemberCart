using System;
using System.Collections.Generic;

namespace BusinessObjects
{
    public partial class StaffOrder
    {
        public int? StaffId { get; set; }
        public int? OrderId { get; set; }
        public DateTime? WorkDate { get; set; }
        public string Status { get; set; }

        public virtual Order Order { get; set; }
        public virtual staff Staff { get; set; }
    }
}
