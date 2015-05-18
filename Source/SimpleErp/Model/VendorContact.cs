using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace simpleerp.model
{
    [Table("VendorContact")]
    public class VendorContact:LookupEntity
    {
        public string Title { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool? IsPrimary { get; set; }

        public virtual Vendor Vendor { get; set; }
    }
}
