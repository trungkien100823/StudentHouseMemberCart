using System;
using System.Collections.Generic;

namespace BusinessObjects
{
    public partial class staff
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? Dob { get; set; }
        public string Sex { get; set; }
        public string Status { get; set; }
        public int? ServiceId { get; set; }

        public virtual Service Service { get; set; }
    }
}
